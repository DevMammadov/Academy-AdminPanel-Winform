using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademyAdminPanel.Model;

namespace AcademyAdminPanel.Forms
{
    public partial class TaskForm : Form
    {
        bool formLoaded = false;
        List<Model.Task> SearchList = new List<Model.Task>(); 
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _rectangle;
        public TaskForm()
        {
            InitializeComponent();

            // Adding Custom DateTimePicker to DataGridView
            dataGridView1.Controls.Add(dtp);
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
            dtp.Visible = false;
            panelHeader.Height = 45; // sort panel invisible

            FormRefresh();
            formLoaded = true;
        }

        // Refresh grid and Combobox from database
        public void FormRefresh()
        {
            using (var db = new AcademyDB())
            {
                SearchList = db.Task.ToList();
                fillGrid(SearchList);

                comboBox1.DataSource = db.Group.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = -1;
            }
        }

        // When selecting Group filtering grid
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (formLoaded && comboBox1.SelectedIndex != -1)
            {
                using (var db = new AcademyDB())
                {
                    Group group = comboBox1.SelectedItem as Group;
                    SearchList = db.Task.Where(t => t.GroupID == group.id).ToList();
                    fillGrid(SearchList);
                }
            }
        }

        // Clear filter 
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var db = new AcademyDB())
            {
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                comboBox1.SelectedIndex = -1;
                FormRefresh();
            }
        }

        // Fill grid Method
        public void fillGrid(List<Model.Task> list)
        {
            dataGridView1.Rows.Clear();
            using (var db = new AcademyDB())
            {
                // Fill comboboxes in datagridview
                dgvCombobox.DataSource = db.Group.Where(g => g.Deleted == false).ToList();
                dgvCombobox.DisplayMember = "Name";
                dgvCombobox.ValueMember = "id";

                foreach (Model.Task task in list)
                {
                    if (task.Deleted == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = task.id;
                        row.Cells[1].Value = task.Name;
                        row.Cells[2].Value = task.Dedline;
                        row.Cells[3].Value = task.GroupID; // set selected group to combobox

                        // if not all students in group has points set orange color
                        int StCount = db.Student.Where(st => st.GroupID == task.GroupID && st.Deleted == false).Count();
                        int exCount = db.Exam.Where(exm => exm.TaskID == task.id).Count();

                        if (StCount > exCount)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(241, 196, 15);
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                        }
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        // Updating Task from datagridView
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (formLoaded && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                int taskID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                using (var db = new AcademyDB())
                {
                    if (CheckRow(e.RowIndex)) // checking cells validation
                    {
                        Model.Task task = db.Task.Where(t => t.id == taskID).FirstOrDefault();

                        task.Name = row.Cells[1].Value.ToString();
                        task.Dedline = Convert.ToDateTime(row.Cells[2].Value);
                        task.GroupID = (int) row.Cells[3].Value;
                       

                        if (db.SaveChanges() != 0)
                        {
                            MessageBox.Show("Task updated");
                            fillGrid(db.Task.ToList());
                        }
                        else
                        {
                            MessageBox.Show("Warning: Task did not updated!");
                        }
                    }
                }
            }
        }

        // Checking rows validation
        public bool CheckRow(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            int cellsCount = 0;
            int valid = 0;
            for (int i = 1; i < row.Cells.Count; i++)
            {
                if (row.Cells[i] is DataGridViewTextBoxCell && row.Cells[i].OwningColumn.Name != "dateTimePickerColumn")
                {
                    if (row.Cells[i].Value is null)
                    {
                        cellsCount++;
                        MessageBox.Show(row.Cells[i].OwningColumn.HeaderText + " is empty!");
                        row.Cells[i].Style.BackColor = Color.FromArgb(255, 118, 117);
                    }
                    else
                    {
                        cellsCount++;
                        if (Validation.CheckCell(row.Cells[i].OwningColumn.HeaderText, row.Cells[i].Value.ToString(), row.Cells[i].OwningColumn.DataPropertyName) == "ok")
                        {
                            valid++;
                            row.Cells[i].Style.BackColor = Color.White;
                        }
                        else
                        {
                            MessageBox.Show(Validation.CheckCell(row.Cells[i].OwningColumn.HeaderText, row.Cells[i].Value.ToString(), row.Cells[i].OwningColumn.DataPropertyName));
                            row.Cells[i].Style.BackColor = Color.FromArgb(255, 118, 117);
                        }
                    }
                }
            }
            if (valid == cellsCount) { return true; }
            else return false;
        }

        // DatagridView Delete || Open Buttons Click
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            // if column is Delete button column
            if (senderGrid.Columns[e.ColumnIndex].Name == "Column4" && e.RowIndex >= 0 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show(row.Cells[1].Value.ToString(), "Are you sure to delete?", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    using (var db = new AcademyDB())
                    {

                        int taskID = (int)row.Cells[0].Value;
                        Model.Task tsk = db.Task.Where(t => t.id == taskID).FirstOrDefault();
                        tsk.Deleted = true;

                        if (db.SaveChanges() != 0)
                        {
                            fillGrid(db.Task.ToList());
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
            // if button is Open task button
            else if(senderGrid.Columns[e.ColumnIndex].Name == "dgvOpen" && e.RowIndex >= 0 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                int taskID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value );

                Controls.RemoveAt(0);
                ExamForm exForm = new ExamForm(taskID);
                exForm.TopLevel = false;
                exForm.Dock = DockStyle.Fill;
                Controls.Add(exForm);
                Tag = exForm;
                exForm.Show();
            }
        }

        // cellClick function | DGV dateTimePicker
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            // if column is dateTimePicker column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "dateTimePickerColumn")
            {
                _rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(_rectangle.Width, _rectangle.Height);
                dtp.Location = new Point(_rectangle.X, _rectangle.Y + 1);
                dtp.Visible = true;
            }
        }

        // on DateTimePicker text change CUSTOM EVENT   
        private void dtp_TextChange(object sender, EventArgs e)
        {
            // find current cell
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int y = 0; y < dataGridView1.Rows[0].Cells.Count; y++)
                {
                    Rectangle rectangle = dataGridView1.GetCellDisplayRectangle(dataGridView1.Rows[i].Cells[y].ColumnIndex, dataGridView1.Rows[i].Cells[y].RowIndex, true);
                    if (rectangle.X == dtp.Location.X && rectangle.Y + 1 == dtp.Location.Y)
                    {

                        dataGridView1.Rows[i].Cells[y].Value = dtp.Text.ToString();
                    }
                }
            }
        }

        // Search System by typing
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;

            using (var db = new AcademyDB())
            {
                List<Model.Task> taskList = db.Task.Where(t => t.Name.Contains(searchText)).ToList();
                fillGrid(taskList);
            }
        }

        // Sorting button press
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (PanelSearchLineBottom.Visible == true)
            {
                PanelSearchLineBottom.Visible = false;
                panelHeader.Height = 45;
            }
            else
            {
                PanelSearchLineBottom.Visible = true;
                panelHeader.Height = 95;
            }
        }

        // searching system between datas (Start Date)
        List<Model.Task> sortedByDateList = new List<Model.Task>();
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            sortedByDateList = SearchList.Where(t => t.Dedline > date1 && t.Dedline < date2).ToList();
            fillGrid(sortedByDateList);
        }

        //Draw icons to datagridview buttons
        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var w = Properties.Resources.task16.Width;
            var h = Properties.Resources.task16.Height;
            var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            if (e.ColumnIndex == 4)
            {
                
                e.Graphics.DrawImage(Properties.Resources.task16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            else if(e.ColumnIndex == 5)
            {
                e.Graphics.DrawImage(Properties.Resources.del16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        // open task form
        private void button3_Click(object sender, EventArgs e)
        {
            Controls.RemoveAt(0);
            addTaskForm addtskFrm = new addTaskForm();
            addtskFrm.TopLevel = false;
            addtskFrm.Dock = DockStyle.Fill;
            Controls.Add(addtskFrm);
            Tag = addtskFrm;
            addtskFrm.Show();
        }
    }
}
