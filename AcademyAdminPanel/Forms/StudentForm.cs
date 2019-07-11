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
    public partial class StudentForm : Form
    {
        bool formLoaded = false;
        List<Student> SearchList = new List<Student>();
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _rectangle;
        public StudentForm()
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

        // Refresh and Combobox from database
        public void FormRefresh()
        {
            using (var db = new AcademyDB())
            {
                SearchList = db.Student.ToList();
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
                    SearchList = db.Student.Where(std => std.GroupID == group.id).ToList();
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
                comboBox1.SelectedIndex = -1;
                checkBox1.Checked = false;
                FormRefresh();
            }
        }

        // Fill grid Method
        public void fillGrid(List<Student> list)
        {
            dataGridView1.Rows.Clear();
            getStatistic();
            using (var db = new AcademyDB())
            {
                // Fill comboboxes in datagridview
                dgvComboboxGroup.DataSource = db.Group.Where(p => p.Deleted == false).ToList();
                dgvComboboxGroup.DisplayMember = "Name";
                dgvComboboxGroup.ValueMember = "id";

                foreach (Student std in list)
                {
                    if (std.Deleted == false && std.Group.Deleted == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = std.id;
                        row.Cells[1].Value = std.Name;
                        row.Cells[2].Value = std.Surname;
                        row.Cells[3].Value = std.Email;
                        row.Cells[4].Value = std.Phone;
                        row.Cells[5].Value = std.Fee;
                        row.Cells[6].Value = std.GroupID; // set selected group to combobox
                        row.Cells[7].Value = std.StartDate;

                        Group gr = db.Group.Where(g => g.id == std.GroupID).FirstOrDefault();

                        // if period of program end. then row will be red
                        if (gr.Program.Period != null) {
                            int periodMonths = (int)gr.Program.Period;
                            DateTime programPeriod = std.StartDate.AddMonths(periodMonths);
                            
                            if ( programPeriod < DateTime.Now)
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 118, 117);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.White;
                                // if student has dept then cell color will be different color
                                if (std.Fee < gr.Program.Price)
                                {
                                    row.Cells[5].Style.BackColor = Color.FromArgb(241, 196, 15);
                                }
                                else
                                {
                                    row.Cells[5].Style.BackColor = Color.White;
                                }
                            }
  
                        }
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        // Updating Student from datagridView
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (formLoaded && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                int stdID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                using (var db = new AcademyDB())
                {
                    if (CheckRow(e.RowIndex)) // checking cells validation
                    {
                        Student std = db.Student.Where(s => s.id == stdID).FirstOrDefault();

                        std.Name = row.Cells[1].Value.ToString();
                        std.Surname = row.Cells[2].Value.ToString();
                        std.Email = row.Cells[3].Value.ToString();
                        std.Phone = row.Cells[4].Value.ToString();
                        std.Fee = Convert.ToDouble(row.Cells[5].Value);
                        std.GroupID = Convert.ToInt32(row.Cells[6].Value);
                        std.StartDate = Convert.ToDateTime(row.Cells[7].Value);

                        if (db.SaveChanges() != 0)
                        {
                            fillGrid(db.Student.ToList());
                            dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(224, 255, 224);
                        }
                        else
                        {
                            MessageBox.Show("Error: Student is not updated!");
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
            for (int i = 1; i < row.Cells.Count - 3; i++)
            {
                if (row.Cells[i] is DataGridViewTextBoxCell)
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
            if (valid == cellsCount) { return true; }
            else return false;
        }

        // DatagridView Delete Button Click
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            // if column is Delete button column
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&  e.RowIndex >= 0 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show(row.Cells[1].Value + " " + row.Cells[2].Value, "Are you sure to delete?", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    using (var db = new AcademyDB())
                    {

                        int stdID = (int)row.Cells[0].Value;
                        Student std = db.Student.Where(s => s.id == stdID).FirstOrDefault();
                        std.Deleted = true;

                        if (db.SaveChanges() != 0)
                        {
                            //Control frm = new Controls.Notification(row.Cells[2].Value + " " + row.Cells[3].Value + " Deleted", "success");
                            //GridPanel.Controls.Add(frm);
                            MessageBox.Show("Deleted");
                            fillGrid(db.Student.ToList());
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
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
            for(int i=0; i < dataGridView1.Rows.Count; i++)
            {
                for(int y=0; y < dataGridView1.Rows[0].Cells.Count; y++)
                {
                    Rectangle rectangle =  dataGridView1.GetCellDisplayRectangle(dataGridView1.Rows[i].Cells[y].ColumnIndex, dataGridView1.Rows[i].Cells[y].RowIndex, true);
                    if(rectangle.X == dtp.Location.X && rectangle.Y+1 == dtp.Location.Y)
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
                List<Student> stdList = db.Student.Where(s => s.Name.Contains(searchText) || s.Surname.Contains(searchText) || s.Email.Contains(searchText) || s.Phone.Contains(searchText)).ToList();
                fillGrid(stdList);
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

        // open add form in main form
        private void button3_Click_1(object sender, EventArgs e)
        {
            Controls.RemoveAt(0);
            addStudentForm addstdFrm = new addStudentForm();
            addstdFrm.TopLevel = false;
            addstdFrm.Dock = DockStyle.Fill;
            Controls.Add(addstdFrm);
            Tag = addstdFrm;
            addstdFrm.Show();
        }

        // searching system between datas (Start Date)
        List<Student> sortedByDateList = new List<Student>();
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            sortedByDateList = SearchList.Where(l => l.StartDate > date).ToList();
            fillGrid(sortedByDateList);
        }

        // Show only dept list of Students
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            List<Student> deptList = new List<Student>();
            if(checkBox1.Checked == true)
            {
                using(var db = new AcademyDB())
                {
                    foreach(Student std in SearchList)
                    {
                        Group grup = db.Group.FirstOrDefault(g => g.id == std.GroupID);
                        if(std.Fee < grup.Program.Price)
                        {
                            deptList.Add(std);
                        }
                    }
                    fillGrid(deptList);
                }
            }
            else
            {
                fillGrid(SearchList);
            }
        }

        // get statistics
        public void getStatistic()
        {
            int stFee = 0;
            using(var db = new AcademyDB())
            {
                foreach(Student st in db.Student)
                {
                    Model.Program prog = db.Program.FirstOrDefault(p => p.Deleted == false && p.Price > st.Fee);
                    if(prog != null)
                    {
                        stFee++;
                    }
                }

                lblStudentCount.Text = db.Student.Where(st => st.Deleted == false).Count().ToString();
                lblDeptorCount.Text = stFee.ToString();
            }
        }

        //Draw icons to datagridview buttons
        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.del16.Width;
                var h = Properties.Resources.del16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.del16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
