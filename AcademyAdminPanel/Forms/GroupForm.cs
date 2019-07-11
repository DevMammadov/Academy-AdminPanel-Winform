using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AcademyAdminPanel.Model;

namespace AcademyAdminPanel.Forms
{
    public partial class GroupForm : Form
    {
        List<Group> SearchList = new List<Group>();
        bool formLoaded = false;
        public GroupForm()
        {
            InitializeComponent();
            FormRefresh();
            formLoaded = true;
            getStatistic();
        }

        // Refresh and Combobox from database
        public void FormRefresh()
        {
            using (var db = new AcademyDB())
            {
                comboBox1.DataSource = db.Program.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = -1;
                
                fillGrid( db.Group.ToList() );

            }
        }

        // Fill grid Method
        public void fillGrid(List<Group> list)
        {
            SearchList.Clear();
            SearchList = list;
            dataGridView1.Rows.Clear();
            using (var db = new AcademyDB())
            {
                // Fill comboboxes in datagridview
                cmbClassroom.DataSource = db.Classroom.Where(c => c.Deleted == false).ToList();
                cmbClassroom.DisplayMember = "Name";
                cmbClassroom.ValueMember = "id";

                cmbTeacher.DataSource = db.Employee.Where(em => em.Position.Name == "Teacher" && em.Deleted == false).ToList();
                cmbTeacher.DisplayMember = "Name";
                cmbTeacher.ValueMember = "id";

                cmbMentor.DataSource = db.Employee.Where(em => em.Position.Name == "Mentor" && em.Deleted == false).ToList();
                cmbMentor.DisplayMember = "Name";
                cmbMentor.ValueMember = "id";

                cmbProgram.DataSource = db.Program.Where(pr => pr.Deleted == false).ToList().ToList();
                cmbProgram.DisplayMember = "Name";
                cmbProgram.ValueMember = "id";

                foreach (Group grp in list)
                {
                    if (grp.Deleted == false)
                    {

                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = grp.id;
                        row.Cells[1].Value = grp.Name;
                        row.Cells[2].Value = grp.ClassroomID;
                        row.Cells[3].Value = grp.TeacherID;
                        row.Cells[4].Value = grp.MentorID;
                        row.Cells[5].Value = grp.Capacity;
                        row.Cells[6].Value = grp.ProgramID;

                        if(grp.MentorID == null)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(241, 196, 15);
                        }
                        else if (grp.TeacherID == null)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 118, 117);
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

        // Updating Group from datagridView
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (formLoaded && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                int groupID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                using (var db = new AcademyDB())
                {
                    if (CheckRow(e.RowIndex)) // checking cells validation
                    {
                        Group grp = db.Group.FirstOrDefault(gr => gr.id == groupID);

                        grp.Name = row.Cells[1].Value.ToString();
                        grp.ClassroomID = Convert.ToInt32(row.Cells[2].Value);
                        grp.TeacherID = Convert.ToInt32(row.Cells[3].Value);
                        grp.MentorID = Convert.ToInt32(row.Cells[4].Value);
                        grp.Capacity = Convert.ToInt32(row.Cells[5].Value);
                        grp.ProgramID = Convert.ToInt32(row.Cells[6].Value);

                        if (db.SaveChanges() != 0)
                        {
                            fillGrid(db.Group.Where(gr=>gr.Deleted == false).ToList());
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

        // DatagridView Delete Button Click
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            // if column is Delete button column
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DialogResult result;

                    using (var db = new AcademyDB())
                    {
                        int grID = (int)row.Cells[0].Value;

                        int studentsC = db.Student.Where(st => st.Deleted == false && st.GroupID == grID).Count();
                        if(studentsC > 0)
                        {
                            result = MessageBox.Show(row.Cells[1].Value + " contains " + studentsC + " students !", "Are you sure to delete?", MessageBoxButtons.OKCancel);
                        }
                        else
                        {
                            result = MessageBox.Show(row.Cells[1].Value.ToString(), "Are you sure to delete?", MessageBoxButtons.OKCancel);
                        }

                    if (result == DialogResult.OK)
                    {
                        Group grup = db.Group.Where(g => g.id == grID).FirstOrDefault();
                        grup.Deleted = true;

                        if (db.SaveChanges() != 0)
                        {
                            fillGrid(db.Group.ToList());
                        }
                        else
                        {
                            MessageBox.Show("Error");
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

        // Search by group name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox1.Text.Trim();
            List<Group> grList = new List<Group>();
            using(var db = new AcademyDB())
            {
                // search by group name and classroom name
                grList = db.Group.Where(gr => gr.Name.Contains(txt) || gr.Classroom.Name.Contains(txt)).ToList();
                
                foreach(Employee emp in db.Employee.ToList())
                {
                    // add search by teacher or mentor name
                    Group grup = db.Group.FirstOrDefault(g => g.TeacherID == emp.id || g.MentorID == emp.id);
                    if(grup != null && emp.Name.Contains(txt) && !grList.Contains(grup))
                    {
                        grList.Add(grup);
                    }
                }

            }
            fillGrid(grList);
        }

        // Sort groups by Program
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Program program = comboBox1.SelectedItem as Model.Program;
            if(formLoaded && comboBox1.SelectedIndex != -1)
            {
                using (var db = new AcademyDB())
                {
                    fillGrid(db.Group.Where(g => g.ProgramID == program.id).ToList());
                }
            }
        }

        // Bottom statistic panel
        public void getStatistic()
        {
            int wTeacher = 0;
            int wMentor = 0;
            int grCount = 0;

            using(var db = new AcademyDB())
            {
                int maxCount = 0;
                string grName = "";
                // Find biggest Group name, Student count, groups without teacher || mentor
                foreach(Group grup in db.Group.ToList())
                {
                    grCount++;
                    int maxG = 0;
                    foreach (Student student in db.Student.ToList())
                    {
                        if(student.GroupID == grup.id)
                        {
                            maxG++;
                        }
                    }
                    if(maxCount < maxG) { maxCount = maxG; grName = grup.Name; }

                    if(grup.TeacherID == null) { wTeacher++; }
                    if(grup.MentorID == null) { wMentor++; }
                }

                lblBiggerGroup.Text = grName + " (" + maxCount + " student)";
                lblGroupCount.Text = grCount.ToString();
                lblWithoutMentor.Text = wMentor.ToString();
                lblWithoutTeacher.Text = wTeacher.ToString();
            }
        }

        // Selected group statistic at bottom
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                int GrID = (int) dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                int studentCount = 0;
                using (var db = new AcademyDB())
                {
                    studentCount = db.Student.Where(s => s.GroupID == GrID).Count();
                }

                lblSelectedGroup.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + " (" + studentCount + " student)";
            }
        }

        //Clear filters
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            using(var db = new AcademyDB())
            {
                fillGrid(db.Group.ToList());
            }
        }

        //Draw icons to datagridview buttons
        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 7)
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

        // open add form
        private void button3_Click(object sender, EventArgs e)
        {
            Controls.RemoveAt(0);
            addGroupForm addgrp = new addGroupForm();
            addgrp.TopLevel = false;
            addgrp.Dock = DockStyle.Fill;
            Controls.Add(addgrp);
            Tag = addgrp;
            addgrp.Show();
        }
    }
}
