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
    public partial class EmployerForm : Form
    {
        bool formLoaded = false;
        List<Employee> SearchList = new List<Employee>();
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _rectangle;

        public EmployerForm()
        {
            InitializeComponent();
            // Adding Custom DateTimePicker to DataGridView
            dataGridView1.Controls.Add(dtp);
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.TextChanged += new EventHandler(dtp_TextChange);
            dtp.Visible = false;
            panelHeader.Height = 45; // sort panel unvisible

            FormRefresh();
            formLoaded = true;
        }


        // Fill Grid and Combobox from database
        public void FormRefresh()
        {
            using (var db = new AcademyDB())
            {
                SearchList = db.Employee.ToList();
                fillGrid(SearchList);
                getStatistic();

                comboBox1.DataSource = db.Position.Where(p=> p.Deleted == false).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = -1;
            }
        }

        // When selecting position filtering grid
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded && comboBox1.SelectedIndex != -1)
            {
                getStatistic();
                using (var db = new AcademyDB())
                {
                    Position position = comboBox1.SelectedItem as Position;

                    fillGrid(db.Employee.Where(emp => emp.PositionID == position.id).ToList());

                    if(position.Name == "Teacher")
                    {
                        comboBox2.Enabled = true;
                        comboBox2.DataSource = db.Program.Where(p => p.Deleted == false).ToList();
                        comboBox2.DisplayMember = "Name";
                        comboBox2.ValueMember = "id";
                        comboBox2.SelectedIndex = -1;
                    }
                    else
                    {
                        comboBox2.DataSource = null;
                        comboBox2.SelectedIndex = -1;
                        comboBox2.Enabled = false;
                    }
                }
            }
        }

        // Clear filter 
        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyDB())
            {
                dateTimePicker1.Value = DateTime.Now;
                txtMaxSalary.Value = 0;
                txtMinSalary.Value = 0;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox2.Enabled = false;
                SearchList = db.Employee.ToList();
                fillGrid(SearchList);
            }
        }

        // Fill grid Method
        public void fillGrid(List<Employee> list)
        {
            dataGridView1.Rows.Clear();
            using (var db = new AcademyDB())
            {
                // Fill comboboxes in datagridview
                dgvCombobox.DataSource = db.Position.Where(p => p.Deleted == false).ToList();
                dgvCombobox.DisplayMember = "Name";
                dgvCombobox.ValueMember = "id";

                foreach (Employee emp in list)
                {
                    if (emp.Deleted == false && emp.Position.Deleted == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                        // if employer not teacher then set readonly to speciality
                        if (emp.SpecialityID != null)
                        {
                            dgvComboboxSp.DataSource = db.Program.Where(p => p.Deleted == false).ToList();
                            dgvComboboxSp.DisplayMember = "Name";
                            dgvComboboxSp.ValueMember = "id";
                            dgvComboboxSp.ReadOnly = false;
                        }
                        else
                        {
                            row.Cells[8].Value = null;
                            row.Cells[8].ReadOnly = true;
                        }

                        row.Cells[0].Value = emp.id;
                        row.Cells[1].Value = emp.Name;
                        row.Cells[2].Value = emp.Surname;
                        row.Cells[3].Value = emp.Email;
                        row.Cells[4].Value = emp.Phone;
                        row.Cells[5].Value = emp.PositionID; // set selected position to combobox
                        row.Cells[6].Value = emp.Salary;
                        row.Cells[7].Value = emp.StartTime;
                        row.Cells[8].Value = emp.SpecialityID; // set selected speciality to combobox2

                        // if teacher is not in any group
                        Group grp = db.Group.FirstOrDefault(g => g.TeacherID == emp.id);
                        if (grp == null && emp.SpecialityID != null)
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

        // Updating Employee from datagridView
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (formLoaded && e.RowIndex != dataGridView1.Rows.Count -1)
            {
                int empID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                using (var db = new AcademyDB())
                {
                    if (CheckRow(e.RowIndex)) // checking cells validation
                    {
                        Employee emp = db.Employee.Where(em => em.id == empID).FirstOrDefault();
                        
                        emp.Name = row.Cells[1].Value.ToString();
                        emp.Surname = row.Cells[2].Value.ToString();
                        emp.Email = row.Cells[3].Value.ToString();
                        emp.Phone = row.Cells[4].Value.ToString();
                        emp.PositionID = Convert.ToInt32(row.Cells[5].Value);
                        emp.Salary = Convert.ToInt32(row.Cells[6].Value);
                        emp.StartTime = Convert.ToDateTime(row.Cells[7].Value);

                        // If user has position than update else set null
                        if (row.Cells[8].Value != null)
                        {
                            emp.SpecialityID = Convert.ToInt32(row.Cells[8].Value);
                        }
                        else
                        {
                            emp.SpecialityID = null;
                        }


                        if (db.SaveChanges() != 0)
                        {
                            fillGrid(db.Employee.ToList());
                            dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(224, 255, 224);
                        }
                        else
                        {
                            MessageBox.Show("Error: Employee did not updated!");
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
                if (row.Cells[i] is DataGridViewComboBoxCell || row.Cells[i] is DataGridViewButtonCell) { continue; }
                cellsCount++;
                if(Validation.CheckCell(row.Cells[i].OwningColumn.HeaderText, row.Cells[i].Value.ToString(),row.Cells[i].OwningColumn.DataPropertyName) == "ok")
                {
                    valid++;
                    row.Cells[i].Style.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show( Validation.CheckCell(row.Cells[i].OwningColumn.HeaderText, row.Cells[i].Value.ToString(), row.Cells[i].OwningColumn.DataPropertyName) );
                    row.Cells[i].Style.BackColor = Color.FromArgb(255, 118, 117);
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
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex >= 0 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                using (var db = new AcademyDB())
                {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        DialogResult result;
                        int empID = (int)row.Cells[0].Value;
                        Employee emp =  db.Employee.Where(em => em.id == empID).FirstOrDefault();
                        Group group = db.Group.FirstOrDefault(g => g.TeacherID == emp.id && g.Deleted == false);

                        if(group != null && emp.SpecialityID != null)
                        {
                             result = MessageBox.Show(row.Cells[1].Value + " " + row.Cells[2].Value + " Working as teacher at " + group.Name, "Are you sure to delete?", MessageBoxButtons.OKCancel);
                        }
                        else if(group != null && emp.SpecialityID == null)
                        {
                             result = MessageBox.Show(row.Cells[1].Value + " " + row.Cells[2].Value + " Working as mentor at " + group.Name, "Are you sure to delete?", MessageBoxButtons.OKCancel);
                        }
                        else
                        {
                             result = MessageBox.Show(row.Cells[1].Value + " " + row.Cells[2].Value, "Are you sure to delete?", MessageBoxButtons.OKCancel);
                        }

                    if (result == DialogResult.OK)
                    {
                        emp.Deleted = true;

                        if(db.SaveChanges() != 0)
                        {
                            MessageBox.Show("Deleted");
                            fillGrid(db.Employee.ToList());
                        }
                        else {
                            MessageBox.Show("Error: Employer was not deleted");
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
        private void dtp_TextChange(object sender,EventArgs e)
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBox1.Text;


            using (var db = new AcademyDB())
            {
                List<Employee> empList = db.Employee.Where(emp => emp.Name.Contains(searchText) || emp.Surname.Contains(searchText) || emp.Email.Contains(searchText) || emp.Phone.Contains(searchText)).ToList();
                fillGrid(empList);
            }
        }
        // Sorting button press
        private void button2_Click(object sender, EventArgs e)
        {
           if(PanelSearchLineBottom.Visible == true){
                PanelSearchLineBottom.Visible = false;
                panelHeader.Height = 45;
            }
            else
            {
                PanelSearchLineBottom.Visible = true;
                panelHeader.Height = 95;
            }
        }

        // searching system between numbers (Salary)
        private void txtMinSalary_TextChanged(object sender, EventArgs e)
        {
            if (txtMaxSalary.Text != string.Empty && txtMinSalary.Text != string.Empty)
            {
                int minS = Convert.ToInt32(txtMinSalary.Text);
                int maxS = Convert.ToInt32(txtMaxSalary.Text);

                DateTime datepickVal = dateTimePicker1.Value;
                

                using (var db = new AcademyDB())
                {
                        SearchList = db.Employee.Where(emp => emp.Salary >= minS && emp.Salary <= maxS).ToList();
                        fillGrid(SearchList);
                }
            }
        }

        // searching system between datas (Start Date)
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            using (var db = new AcademyDB())
            {
                    SearchList = db.Employee.Where(emp => emp.StartTime >= date).ToList();
                    fillGrid(SearchList);
            }
        }

        // Search Teachers by Speciality
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Program program = comboBox2.SelectedItem as Model.Program;
            
            using(var db = new AcademyDB())
            {
                if (comboBox2.Focused)
                {
                    SearchList = db.Employee.Where(emp => emp.SpecialityID == program.id).ToList();
                    fillGrid(SearchList);
                }
            }
        }

        // Get Statistic
        public void getStatistic()
        {
            using (var db = new AcademyDB())
            {
                int empCount = 0;
                int freeTeacher = 0;
                lblEmployers.Text = db.Employee.Where(em => em.Deleted == false).Count().ToString();

                foreach(Employee emp in db.Employee.Where(em=> em.Deleted == false).ToList())
                {
                    Group grp = db.Group.FirstOrDefault(gr => gr.Deleted == false && gr.TeacherID == emp.id);
                    if(grp == null && emp.SpecialityID != null)
                    {
                        freeTeacher++;
                    }
                }

                lblFreeTeacher.Text = freeTeacher.ToString();

                if(comboBox1.SelectedIndex != -1)
                {
                    Position pos = comboBox1.SelectedItem as Position;
                    empCount = db.Employee.Where(emp => emp.PositionID == pos.id && emp.Deleted == false).Count();

                    lblSelectedPosition.Text = pos.Name + " ( " + empCount + " employers )";
                }
            }
        }

        //Draw icons to datagridview buttons
        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 9)
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
        // open add form in main form
        private void button3_Click(object sender, EventArgs e)
        {

            Controls.RemoveAt(0);
            addEmployeeForm addempFrm = new addEmployeeForm();
            addempFrm.TopLevel = false;
            addempFrm.Dock = DockStyle.Fill;
            Controls.Add(addempFrm);
            Tag = addempFrm;
            addempFrm.Show();
        }

    }
}
