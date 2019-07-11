using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AcademyAdminPanel.Model;

namespace AcademyAdminPanel.Forms
{
    public partial class ExamForm : Form
    {
        int RecivedTaskID;
        List<Student> SearchList = new List<Student>();
        Task currentTask = new Task();
        bool formLoaded = false;
        public ExamForm(int Tid)
        {
            InitializeComponent();
            RecivedTaskID = Tid;
            FormRefresh();
            formLoaded = true;
        }

        // Refresh grid and Combobox from database
        public void FormRefresh()
        {
            using (var db = new AcademyDB())
            {
                currentTask = db.Task.Where(t => t.id == RecivedTaskID).FirstOrDefault();
                comboBox1.DataSource = db.Task.Where(t => t.Deleted == false).ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedItem = currentTask;

                Group currentGroup = db.Group.FirstOrDefault(g => g.id == currentTask.GroupID);
                comboBox2.DataSource = db.Group.Where(t => t.Deleted == false).ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "id";
                comboBox2.SelectedItem = currentGroup;

                fillGrid(currentTask);
            }
        }

        // Fill current Exam to grid
        public void fillGrid(Task task)
        {
            dataGridView1.Rows.Clear();
            SearchList.Clear();
            getStatistics(task);

            using (var db = new AcademyDB())
            {
                List<Student> studentList = db.Student.Where(s => s.GroupID == task.GroupID).ToList();
                SearchList = studentList;

                fillSearchList(SearchList);
            }
        }


        // fill searchList students to grid
        public void fillSearchList(List<Student> list)
        {
            dataGridView1.Rows.Clear();
            using (var db = new AcademyDB())
            {
                foreach (Student student in list)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                    int? point = null;
                    Exam exam = db.Exam.FirstOrDefault(ex => ex.StudentID == student.id);
                    if (exam != null)
                    {
                        point = exam.Point;
                    }

                    Task currentTask = comboBox1.SelectedItem as Task;

                    row.Cells[0].Value = student.id;
                    row.Cells[1].Value = student.Name + " " + student.Surname;
                    row.Cells[2].Value = currentTask.Name;
                    row.Cells[3].Value = point;

                    // if student point is null
                    if (point == null)
                    {
                        row.Cells[3].Style.BackColor = Color.FromArgb(241, 196, 15);
                    }
                    else
                    {
                        row.Cells[3].Style.BackColor = Color.White;
                    }
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        // Update or add Exam.
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                using (var db = new AcademyDB())
                {
                    if (CheckCell(e.RowIndex))
                    {
                        int studentID = Convert.ToInt32(row.Cells[0].Value);
                        string taskName = currentTask.Name;
                        Task task = db.Task.FirstOrDefault(t=> t.Name == taskName);
                        Exam exam = db.Exam.FirstOrDefault(ex => ex.StudentID == studentID && ex.TaskID == task.id);

                        // if exam not contain this student then add students point
                        if (exam is null)
                        {
                            Exam newExam = new Exam()
                            {
                                StudentID = studentID,
                                TaskID = task.id,
                                Point = Convert.ToInt32(row.Cells[3].Value)
                            };

                            db.Exam.Add(newExam);

                            if(db.SaveChanges() == 0)
                            {
                                MessageBox.Show("Warning: Point did not changed");
                            }
                            else { getStatistics(currentTask); }
                        }
                        // else if exam contains this student then update point
                        else
                        {
                            exam.Point = Convert.ToInt32(row.Cells[3].Value);
                            if (db.SaveChanges() == 0)
                            {
                                MessageBox.Show("Warning: Point did not changed");
                            }
                            else { getStatistics(currentTask); }
                        }
                    }
                }
            }
        }


        // Checking rows validation
        public bool CheckCell(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            bool valid = false;
            if(row.Cells[3].Value is null)
            {
                MessageBox.Show("Point cell is empty");
                row.Cells[3].Style.BackColor = Color.FromArgb(255, 118, 117);
            }
            else
            {
                if (Validation.CheckCell(row.Cells[3].OwningColumn.HeaderText,row.Cells[3].Value.ToString(), row.Cells[3].OwningColumn.DataPropertyName) == "ok")
                {
                    valid = true;
                    row.Cells[3].Style.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show(Validation.CheckCell(row.Cells[3].OwningColumn.HeaderText, row.Cells[3].Value.ToString(), row.Cells[3].OwningColumn.DataPropertyName));
                    row.Cells[3].Style.BackColor = Color.FromArgb(255, 118, 117);
                }
            }

            return valid;
        }

        // Search for student
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            using (var db = new AcademyDB())
            {
                List<Student> studentList = db.Student.Where(s => s.GroupID == currentTask.GroupID && s.Name.Contains(searchText) || s.Surname.Contains(searchText)).ToList();
                SearchList = studentList;
                fillSearchList(SearchList);
            }
        }

        // Sort button click
        private void button2_Click(object sender, EventArgs e)
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

        // when selecting Group fill Tasks combobox
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var db = new AcademyDB())
            {
                try
                {
                    Group selectedGr = comboBox2.SelectedItem as Group;
                    comboBox1.DataSource = db.Task.Where(t => t.GroupID == selectedGr.id).ToList();
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "id";
                    comboBox1.SelectedIndex = 0;
                }
                catch (Exception) { };
            }
        }
        // when selecting Task
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task selectedTask = comboBox1.SelectedItem as Task;
            if(formLoaded && selectedTask != null)
            {
                currentTask = selectedTask;
                fillGrid(selectedTask);
            }
        }

        // Clear some filters
        private void button1_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox1.Text = string.Empty;
            Task selectedTask =  comboBox1.SelectedItem as Task;

            foreach(Control con in PanelSearchLineBottom.Controls)
            {
                con.Enabled = true;
            }

            currentTask = comboBox1.SelectedItem as Task;
            fillGrid(currentTask);
            
        }

        // Search in search list BETWEEN given numbers
        List<Student> numberList = new List<Student>();
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numberList.Clear();
            int minPoint = (int)numericUpDown1.Value;
            int maxPoint = (int)numericUpDown2.Value;
            Task currentTask = comboBox1.SelectedItem as Task;
            
            using (var db = new AcademyDB())
            {
                foreach (Student student in SearchList)
                {
                    Exam exam = db.Exam.FirstOrDefault(ex => ex.StudentID == student.id && ex.TaskID == currentTask.id && ex.Point != null && ex.Point >= minPoint && ex.Point <= maxPoint);
                    if(exam != null)
                    {
                        numberList.Add( student );
                    }
                }
            }
            fillSearchList(numberList);
        }

        // Search for only without evaluations
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                checkBox3.Checked = false;
                checkBox3.Enabled = false;
                comboBox3.SelectedIndex = -1;
                comboBox3.Enabled = false;
                Task currentTask = comboBox1.SelectedItem as Task;
                List<Student> PointList = new List<Student>();

                using (var db = new AcademyDB())
                {
                    foreach (Student student in SearchList)
                    {
                        Exam exam = db.Exam.FirstOrDefault(ex => ex.StudentID == student.id && ex.TaskID == currentTask.id);

                        if (exam == null)
                        {
                             PointList.Add(student);
                        }
                    }
                }
                fillSearchList(PointList);
            }
            else
            {
                foreach (Control con in PanelSearchLineBottom.Controls)
                {
                    con.Enabled = true;
                }
                fillSearchList(SearchList);
            }
        }

        // Search only width evaluations
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = false;
            checkBox4.Enabled = false;
            if (checkBox3.Checked == true)
            {

                Task currentTask = comboBox1.SelectedItem as Task;
                List<Student> PointList = new List<Student>();

                using (var db = new AcademyDB())
                {
                    foreach (Student student in SearchList)
                    {
                        Exam exam = db.Exam.FirstOrDefault(ex => ex.StudentID == student.id && ex.TaskID == currentTask.id);

                        if (exam != null)
                        {
                            PointList.Add(student);
                        }
                    }
                }
                fillSearchList(PointList);
            }
            else
            {
                checkBox4.Enabled = true;
                fillSearchList(SearchList);
            }
        }

        // Sorting list by average point
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Student> averageList = new List<Student>();

            if(comboBox3.SelectedIndex > -1)
            {
                using(var db = new AcademyDB())
                {
                    Task currentTask = comboBox1.SelectedItem as Task;
                    double? average = db.Exam.Where(ex => ex.TaskID == currentTask.id).Average(ex => ex.Point);

                    foreach (Student student in SearchList)
                    {
                        if(comboBox3.SelectedIndex == 0)
                        {
                            Exam exam = db.Exam.FirstOrDefault(ex => ex.StudentID == student.id && ex.TaskID == currentTask.id && ex.Point < average);
                            if (exam != null)
                            {
                                averageList.Add(student);
                            }
                        }
                        else if(comboBox3.SelectedIndex == 1)
                        {
                           
                            Exam exam = db.Exam.FirstOrDefault(ex => ex.StudentID == student.id && ex.TaskID == currentTask.id && ex.Point > average);
                            if (exam != null)
                            {
                                averageList.Add(student);
                            }
                        }
                        else if(comboBox3.SelectedIndex == 2)
                        {
                            averageList.Add(student);
                        }
                    }
                    fillSearchList(averageList);
                }
            }
        }

        // Calculate bottom statistics panel
        public void getStatistics(Task task)
        {
            int withoutPintCount = 0;
            double? averagePoint = 0;
            string exellantStudent = "";
            int? maxPoint = 0;
            int studentCount = 0;

            using(var db = new AcademyDB())
            {
                List<Student> studentList = db.Student.Where(s => s.GroupID == task.GroupID).ToList();
                studentCount = studentList.Count();
                averagePoint = db.Exam.Where(ex => ex.TaskID == task.id).Average(ex => ex.Point);
                maxPoint = db.Exam.Where(ex => ex.TaskID == task.id).Max(ex => ex.Point);

                foreach (Student student in studentList)
                {
                    Exam exam = db.Exam.FirstOrDefault(ex => ex.StudentID == student.id && ex.TaskID == task.id);
                    if(exam == null)
                    {
                        withoutPintCount++;
                    }
                    Exam maxExam = db.Exam.FirstOrDefault(ex=> ex.StudentID == student.id && ex.TaskID == task.id && ex.Point == maxPoint);
                    if(maxExam != null)
                    {
                        exellantStudent = student.Name + " " + student.Surname;
                    }
                }
            }

            lblCurrentTask.Text = task.Name;
            lblStudentCount.Text = studentCount.ToString();
            lblWithoutPoint.Text = withoutPintCount.ToString();
            lblAveragePoint.Text = Convert.ToString(Math.Floor(Convert.ToDouble( averagePoint )));
            lblExellantStudent.Text = exellantStudent;
            lblMaxPoint.Text = "( "+ maxPoint + " )";

        }

        // Go back to tasks
        private void button3_Click(object sender, EventArgs e)
        {
            Controls.RemoveAt(0);
            TaskForm taskfrm = new TaskForm();
            taskfrm.TopLevel = false;
            taskfrm.Dock = DockStyle.Fill;
            Controls.Add(taskfrm);
            Tag = taskfrm;
            taskfrm.Show();
        }
    }
}
