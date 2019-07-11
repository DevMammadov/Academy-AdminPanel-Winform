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
    public partial class ClassroomsForm : Form
    {
        bool formLoaded = false;
        public ClassroomsForm()
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
                fillGrid(db.Classroom.ToList());
            }
        }

        // Fill grid Method
        public void fillGrid(List<Classroom> list)
        {
            dataGridView1.Rows.Clear();
            getStatistic();
            using (var db = new AcademyDB())
            {
                foreach (Classroom cls in list)
                {
                    if (cls.Deleted == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = cls.id;
                        row.Cells[1].Value = cls.Name;
                        row.Cells[2].Value = cls.Capacity;

                        // if group is free then set different color
                        Group grup = db.Group.FirstOrDefault(gr => gr.ClassroomID == cls.id);
                        if (grup == null)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(186, 252, 186);
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


        // Add classroom
        private void button1_Click(object sender, EventArgs e)
        {
            string ClsName = textBox1.Text.ToLower();
            using (var db = new AcademyDB())
            {
                Classroom exitCls = db.Classroom.FirstOrDefault(c=> c.Deleted == false && c.Name.ToLower() == ClsName);
                if (isValid())
                {
                    if (exitCls == null)
                    {
                        Classroom newClassroom = new Classroom()
                        {
                            Name = textBox1.Text,
                            Capacity = Convert.ToInt32(textBox2.Text)
                        };

                        db.Classroom.Add(newClassroom);

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
                        MessageBox.Show("Classroom width this name is alredy exist");
                    }
                }
            }
        }

        // Updating Classroom from datagridView
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (formLoaded && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                int clsID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                using (var db = new AcademyDB())
                {
                    if (CheckRow(e.RowIndex)) // checking cells validation
                    {
                        Classroom cls = db.Classroom.FirstOrDefault(c => c.id == clsID);

                        cls.Name = row.Cells[1].Value.ToString();
                        cls.Capacity = Convert.ToInt32(row.Cells[2].Value);

                        if (db.SaveChanges() != 0)
                        {
                            fillGrid(db.Classroom.ToList());
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

        // Search classroom
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox3.Text;

            using (var db = new AcademyDB())
            {
                List<Classroom> clsList = db.Classroom.Where(c => c.Name.Contains(searchText)).ToList();
                fillGrid(clsList);
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
                        int clsID = (int)row.Cells[0].Value;
                        Classroom cls = db.Classroom.FirstOrDefault(c => c.id == clsID);
                        Group grup = db.Group.FirstOrDefault(gr=> gr.ClassroomID == clsID);

                        if(grup != null)
                        {
                            DialogResult res =  MessageBox.Show("The "+ cls.Name +" contains group " + grup.Name + " if u will delete this classroom all group will be deleted", "Are you sure to delete?", MessageBoxButtons.OKCancel);
                            
                            if(res == DialogResult.OK)
                            {
                                cls.Deleted = true;
                            }
                        }
                        else
                        {
                            cls.Deleted = true;
                        }

                        if (db.SaveChanges() != 0)
                        {

                            refreshForm();
                        }
                        else
                        {
                            MessageBox.Show("Classroom not deleted");
                        }
                    }
                }
            }
        }

        // get statistic
        public void getStatistic()
        {
            int freeCls = 0;
            int fullCls = 0;
            using (var db = new AcademyDB()){
                foreach (Classroom cls in db.Classroom.Where(c=> c.Deleted == false).ToList())
                {
                    Group grup = db.Group.FirstOrDefault(g=> g.ClassroomID == cls.id);
                    if(grup == null)
                    {
                        freeCls++;
                    }
                    else
                    {
                        fullCls++;
                    }
                }

                lblClassroomCount.Text = db.Classroom.Where(c => c.Deleted == false).Count().ToString();
                lblFreeClassroom.Text = freeCls.ToString();
                lblFullClassroom.Text = fullCls.ToString();
            }
        }

        //Selected classroom statistic
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string groupInCls = "";
            string selectedCls = "";
            int studentCount = 0;
            if(e.RowIndex != -1 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
              int clsID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

              using(var db = new AcademyDB())
                {
                    Classroom cls = db.Classroom.FirstOrDefault(c => c.id == clsID);
                    Group group = db.Group.FirstOrDefault(g => g.ClassroomID == clsID);
                    
                    selectedCls = cls.Name;
                    if (group != null)
                    {
                        studentCount = db.Student.Where(s => s.GroupID == group.id).Count();
                        groupInCls = " ( Group: " + group.Name + " Students: "+ studentCount + " )";
                    }
                    else
                    {
                        groupInCls = " ( Empty )";
                    }

                    lblSelectedClassRoom.Text = selectedCls + groupInCls;
                }
            }
        }

        //Draw icons to datagridview buttons
        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 3)
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
