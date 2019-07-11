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
   
    public partial class ProgramsForm : Form
    {
        bool formLoaded = false;
        public ProgramsForm()
        {
            InitializeComponent();
            refreshForm();
            formLoaded = true;
        }

        // Refresh form
        public void refreshForm()
        {
            using (var db = new AcademyDB())
            {
                fillGrid(db.Program.ToList());
            }
        }

        // Fill grid Method
        public void fillGrid(List<Model.Program> list)
        {
            dataGridView1.Rows.Clear();
            getStatistic();
            using (var db = new AcademyDB())
            {
                foreach (Model.Program prog in list)
                {
                    if (prog.Deleted == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = prog.id;
                        row.Cells[1].Value = prog.Name;
                        row.Cells[2].Value = prog.Price;
                        row.Cells[3].Value = prog.Period;
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }
        // Add program
        private void button1_Click(object sender, EventArgs e)
        {
            string progName = textBox1.Text.ToLower();
            using (var db = new AcademyDB())
            {
                Model.Program exitProg = db.Program.FirstOrDefault(c => c.Deleted == false && c.Name.ToLower() == progName);


                if (isValid())
                {
                    if (exitProg == null)
                    {
                        Model.Program newProgram = new Model.Program()
                        {
                            Name = textBox1.Text,
                            Price = Convert.ToInt32(textBox2.Text),
                            Period = Convert.ToInt32(textBox3.Text)

                        };

                        db.Program.Add(newProgram);

                        if (db.SaveChanges() == 0)
                        {
                            MessageBox.Show("Error: Classroom did not added");
                        }
                        else
                        {
                            ClearInputs();
                            refreshForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The program width this name is alredy exist");
                    }
                }
            }
        }

        // Updating Program from datagridView
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (formLoaded && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                int progID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                using (var db = new AcademyDB())
                {
                    if (CheckRow(e.RowIndex)) // checking cells validation
                    {
                        Model.Program prog = db.Program.FirstOrDefault(c => c.id == progID);

                        prog.Name = row.Cells[1].Value.ToString();
                        prog.Price = Convert.ToInt32(row.Cells[2].Value);
                        prog.Period = Convert.ToInt32(row.Cells[3].Value);

                        if (db.SaveChanges() != 0)
                        {
                            fillGrid(db.Program.ToList());
                            dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(224, 255, 224);
                        }
                        else
                        {
                            MessageBox.Show("Warning: Program did not updated!");
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
                if (row.Cells[i] is DataGridViewTextBoxCell)
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

        // Ipnut validation
        public bool isValid()
        {
            int inputCount = 0;
            int valid = 0;
            foreach (Control con in panelAdd.Controls)
            {
                if (con is TextBox)
                {
                    inputCount++;
                    if (Validation.CheckCell(con.AccessibleName, con.Text, con.AccessibleDescription) == "ok")
                    {
                        valid++;
                    }
                    else
                    {
                        ToolTip toolTip = new ToolTip();
                        toolTip.IsBalloon = true;
                        toolTip.Show(Validation.CheckCell(con.AccessibleName, con.Text, con.AccessibleDescription), con, 50, -50, 2000);
                    }
                }
            }
            if (valid == inputCount)
            {
                return true;
            }
            else return false;
        }

        // Clear inputs
        public void ClearInputs()
        {
            foreach (Control con in panelAdd.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
            }
        }

        // Search Program
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox4.Text;
            using (var db = new AcademyDB())
            {
                List<Model.Program> progList = db.Program.Where(c => c.Name.Contains(searchText) && c.Deleted == false).ToList();
                fillGrid(progList);
            }
        }

        // Delete button
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            // if column is Delete button column
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show(row.Cells[1].Value.ToString(), "Are you sure to delete?", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    using (var db = new AcademyDB())
                    {
                        int progID = (int)row.Cells[0].Value;
                        Model.Program prog = db.Program.FirstOrDefault(c => c.id == progID);

                        string groups = string.Join(" , ", db.Group.Where(gr => gr.ProgramID == progID && gr.Deleted == false).Select(g=> g.Name));
                        int empCount = db.Employee.Where(em => em.SpecialityID == progID && em.Deleted == false).Count();
                        if (groups.Length > 0 || empCount > 0)
                        {
                            DialogResult res = MessageBox.Show("The " + prog.Name + " contains groups: " + groups + " and " + empCount + " teachers if you will delete this program all groups and students will be invisible in list", "Are you sure to delete?", MessageBoxButtons.OKCancel);

                            if (res == DialogResult.OK)
                            {
                                prog.Deleted = true;
                            }
                        }
                        else
                        {
                            prog.Deleted = true;
                        }

                        if (db.SaveChanges() != 0)
                        {
                            refreshForm();
                        }
                        else
                        {
                            MessageBox.Show("Classroom did not deleted");
                        }
                    }
                }
            }
        }

        // get statistic
        public void getStatistic()
        {
            using (var db = new AcademyDB())
            {
                int freeProg = 0;
                int progCount = 0;
                
                foreach(Model.Program prog in db.Program.Where(pr=> pr.Deleted == false).ToList())
                {
                    Employee emp = db.Employee.FirstOrDefault(em => em.SpecialityID == prog.id && em.Deleted == false);
                    Group grup = db.Group.FirstOrDefault(gr => gr.ProgramID == prog.id && gr.Deleted == false);

                    if(emp == null && grup == null)
                    {
                        freeProg++;
                    }
                    progCount++;
                }

                lblFreeProgram.Text = freeProg.ToString();
                lblProgramCount.Text = progCount.ToString();
            }
        }

        //Selected program statistic
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != dataGridView1.Rows.Count - 1) {
                {
                    int progID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    using (var db = new AcademyDB())
                    {
                        string progName = db.Program.FirstOrDefault(pr => pr.id == progID && pr.Deleted == false).Name;
                        int TeacherCount = db.Employee.Where(emp => emp.SpecialityID == progID && emp.Deleted == false).Count();
                        int GroupCount = db.Group.Where(gr => gr.ProgramID == progID && gr.Deleted == false).Count();

                        lblSelectedProgram.Text = progName + " ( Groups: " + GroupCount + " Teachers: " + TeacherCount + " )";
                    }
                }
            }
        }

        //Draw icons to datagridview buttons
        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 4)
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
