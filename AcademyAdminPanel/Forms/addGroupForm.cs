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
    public partial class addGroupForm : Form
    {
        bool formLoaded = false;
        public addGroupForm()
        {
            InitializeComponent();
            fillCombobox();
            formLoaded = true;
        }

        // fill comboboxes
        public void fillCombobox()
        {
            using(var db = new AcademyDB())
            {
                List<Employee> MentorList = new List<Employee>();
                List<Classroom> classroomList = new List<Classroom>();
                foreach (Employee employee in db.Employee.ToList())
                {
                    // get only Free Mentors from employers
                    Group grup = db.Group.FirstOrDefault(gr => gr.MentorID == employee.id);
                    if (grup == null && employee.Position.Name == "Mentor")
                    {
                        MentorList.Add(employee);
                    }
                }

                foreach (Classroom cls in db.Classroom.ToList())
                {
                    // get only Free Classroom from Classrooms
                    Group grup = db.Group.FirstOrDefault(gr => gr.ClassroomID == cls.id);
                    if (grup == null)
                    {
                        classroomList.Add(cls);
                    }
                }

                comboBox1.DataSource = db.Program.ToList();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = -1;

                comboBox3.DataSource = MentorList;
                comboBox3.DisplayMember = "Name";
                comboBox3.ValueMember = "id";
                comboBox3.SelectedIndex = -1;

                comboBox4.DataSource = classroomList;
                comboBox4.DisplayMember = "Name";
                comboBox4.ValueMember = "id";
                comboBox4.SelectedIndex = -1;
            }
        }

        // When selecting program fill teacher
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> TeacherList = new List<Employee>();
            Model.Program program = comboBox1.SelectedItem as Model.Program;
            if (formLoaded && comboBox1.SelectedIndex != -1)
            {
                using (var db = new AcademyDB())
                {
                    foreach (Employee employee in db.Employee.ToList())
                    {
                        // get only Free Teachers from employers
                        Group grup = db.Group.FirstOrDefault(gr => gr.TeacherID == employee.id);
                        if(grup == null && employee.SpecialityID == program.id)
                        {
                            TeacherList.Add(employee);
                        }
                    }
                    comboBox2.DataSource = null;
                    comboBox2.DataSource = TeacherList;
                    comboBox2.DisplayMember = "Name";
                    comboBox2.ValueMember = "id";
                }
            }
            comboBox2.Enabled = true;
        }

        // Adding group
        private void button1_Click(object sender, EventArgs e)
        {
            Model.Program program = comboBox1.SelectedItem as Model.Program;
            Classroom classroom = comboBox4.SelectedItem as Classroom;

           
            int? TeacherID, MentorID;
            Employee Mentor = comboBox3.SelectedItem as Employee;

            if(comboBox2.SelectedItem != null)
            {
                Employee Teacher = comboBox2.SelectedItem as Employee;
                TeacherID = Teacher.id;
            }
            else
            {
                TeacherID = null;
            }
            if (comboBox3.SelectedItem != null)
            {
                Employee Teacher = comboBox3.SelectedItem as Employee;
                MentorID = Mentor.id;
            }
            else
            {
                MentorID = null;
            }

            string GrpName = textBox1.Text.ToLower().Trim();
            using (var db = new AcademyDB())
            {
                Group exitGroup = db.Group.FirstOrDefault(gr => gr.Deleted == false && gr.Name.ToLower() == GrpName);

                if(exitGroup == null) {
                    if (isValid())
                    {
                        Group grup = new Group()
                        {
                            Name = textBox1.Text,
                            ProgramID = program.id,
                            TeacherID = TeacherID,
                            MentorID = MentorID,
                            Capacity = Convert.ToInt32(txtCapacity.Text),
                            ClassroomID = classroom.id
                        };

                        db.Group.Add(grup);
                        if (db.SaveChanges() != 0)
                        {
                            MessageBox.Show("Group added!");
                            fillCombobox();
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("Error: Group did not added");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The group width this name alredy exist!");
                }
            }
        }

        // Ipnut validation
        public bool isValid()
        {
            int inputCount = 0;
            int valid = 0;

            foreach (Control con in panelInput.Controls)
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
                        toolTip.Show(Validation.CheckCell(con.AccessibleName, con.Text, con.AccessibleDescription), con, 150, -50, 2000);
                    }
                }
                else if(con is ComboBox && con != comboBox2 && con != comboBox3)
                {
                    inputCount++;
                    if ((con as ComboBox).SelectedIndex != -1)
                    {
                        valid++;
                    }
                    else
                    {
                        ToolTip toolTip = new ToolTip();
                        toolTip.IsBalloon = true;
                        toolTip.Show("Select any " + con.AccessibleName, con, 150, -50, 2000);
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
            foreach (Control con in panelInput.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
                else if (con is ComboBox)
                {
                    (con as ComboBox).SelectedIndex = -1;
                }
            }
        }

        // Warning if capacity of class lower than capacity of group
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                Classroom classroom = comboBox4.SelectedItem as Classroom;
                int groupCapacity = 0;
                if (txtCapacity.Text != string.Empty)
                {
                    groupCapacity = Convert.ToInt32(txtCapacity.Text);
                }


                if (classroom != null && classroom.Capacity < groupCapacity)
                {
                    lblWarning.Text = "Warning: Capacity of " + classroom.Name + " lower than " + groupCapacity;
                }
                else
                {
                    lblWarning.Text = "";
                }
            }
        }

        // Formatting comboboxex display member as name surname
        private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            string name = ((Employee)e.ListItem).Name;
            string surname = ((Employee)e.ListItem).Surname;
            e.Value = name + " " + surname;
        }
    }
}
