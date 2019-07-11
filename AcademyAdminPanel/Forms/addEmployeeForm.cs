using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;
using AcademyAdminPanel.Model;

namespace AcademyAdminPanel.Forms
{
    public partial class addEmployeeForm : Form
    {
        string selectedImage;
        bool formLoaded = false;

        public addEmployeeForm()
        {
            InitializeComponent();
            fillCombobox();
            formLoaded = true;
        }

        // Select picture, creating folder in D:\ and save image
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.Title = "Please select an image file.";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(@"D:\AcademyMembers"))
                    Directory.CreateDirectory(@"D:\AcademyMembers");

                if (!Directory.Exists(@"D:\AcademyMembers\Employers"))
                    Directory.CreateDirectory(@"D:\AcademyMembers\Employers");

                string imgName = dialog.SafeFileName;
                selectedImage = imgName;
                try
                {
                    File.Copy(dialog.FileName, @"D:\AcademyMembers\Employers" + imgName);
                }
                catch(Exception) { }
                pictureBox1.ImageLocation = dialog.FileName;
            }
        }

        // Save employee
        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyDB())
            {
                if (isValid())
                {

                    Position position = comboBox2.SelectedItem as Position;
                    int? SpecID = null;

                    if (comboBox3.SelectedIndex != -1)
                    {
                        Model.Program program = comboBox3.SelectedItem as Model.Program;
                        SpecID = program.id;
                    }

                    string email = textBox3.Text.Trim();
                    Employee exitEmp = db.Employee.FirstOrDefault(em => em.Deleted == false && em.Email == email);

                    if (exitEmp == null)
                    {
                        Employee emp = new Employee()
                        {
                            Name = textBox1.Text,
                            Surname = textBox2.Text,
                            Email = textBox3.Text,
                            Phone = textBox4.Text,
                            PositionID = position.id,
                            Salary = Convert.ToDouble(textBox6.Text),
                            StartTime = dateTimePicker2.Value,
                            Deleted = false,
                            Photo = selectedImage,
                            SpecialityID = SpecID
                        };

                        db.Employee.Add(emp);

                        if (db.SaveChanges() != 0)
                        {
                            MessageBox.Show("Employee added");
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("Error: Employee did not added");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This email is alredy registered as " + exitEmp.Name + " " + exitEmp.Surname);
                    }
                }
            }
        }

        // fill comboboxes
        public void fillCombobox()
        {
            using(var db = new AcademyDB())
            {
                
                comboBox2.DataSource = db.Position.Where(p => p.Deleted == false).ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "id";
                comboBox2.SelectedIndex = -1;
            }
        }

        // fill Specality combobox
        public void fillSpeciality()
        {
            using (var db = new AcademyDB())
            {
                Position selectedPosition = comboBox2.SelectedItem as Position;

                if (selectedPosition.Name == "Teacher")
                {
                    comboBox3.DataSource = db.Program.Where(p=> p.Deleted == false).ToList();
                    comboBox3.DisplayMember = "Name";
                    comboBox3.ValueMember = "id";
                    comboBox3.Enabled = true;
                }
                else
                {
                    comboBox3.DataSource = null;
                    comboBox3.Enabled = false;
                }
            }
            
        }


        // fill speciality if Teacher selected
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (formLoaded && comboBox2.SelectedIndex != -1)
            {
                fillSpeciality();
            }
        }

        // Ipnut validation
        public bool isValid()
        {
            int inputCount = 1; // textboxes + combobox
            int valid = 0;

            foreach(Control con in panelInput.Controls)
            {

                if(con is TextBox)
                {
                    inputCount++;

                    if ( Validation.CheckCell(con.AccessibleName,con.Text,con.AccessibleDescription) == "ok")
                    {
                        valid++;
                    }
                    else
                    {
                        ToolTip toolTip = new ToolTip();
                        toolTip.IsBalloon = true;
                        toolTip.Show(Validation.CheckCell(con.AccessibleName, con.Text, con.AccessibleDescription),con,150,-50,2000);
                    }
                }
            }

            if(comboBox2.SelectedIndex != -1)
            {
                valid++;
            }
            else
            {
                ToolTip toolTip = new ToolTip();
                toolTip.IsBalloon = true;
                toolTip.Show("Select position to employee", comboBox2, 150, -50, 2000);

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
            foreach(Control con in panelInput.Controls)
            {
                if(con is TextBox)
                {
                    con.Text = string.Empty;
                }
                else if(con is ComboBox)
                {
                    (con as ComboBox).SelectedIndex = -1;
                }
                else if(con is DateTimePicker)
                {
                    (con as DateTimePicker).Value = DateTime.Now;
                }
            }
        }

    }
}
