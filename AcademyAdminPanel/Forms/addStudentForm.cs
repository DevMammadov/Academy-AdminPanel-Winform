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
using System.IO;

namespace AcademyAdminPanel.Forms
{
    public partial class addStudentForm : Form
    {
        string selectedImage;
        bool formLoaded = false;
        public addStudentForm()
        {
            InitializeComponent();
            fillCombobox();
            formLoaded = true;
        }

        // Select picture, creating folder in D:\ and save image
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.Title = "Please select an image file.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(@"D:\AcademyMembers"))
                    Directory.CreateDirectory(@"D:\AcademyMembers");

                if(!Directory.Exists(@"D:\AcademyMembers\Students"))
                    Directory.CreateDirectory(@"D:\AcademyMembers\Students");

                string imgName = dialog.SafeFileName;
                selectedImage = imgName;
                try
                {
                    File.Copy(dialog.FileName, @"D:\AcademyMembers\Students" + imgName);
                }
                catch (Exception) { }
                pictureBox2.ImageLocation = dialog.FileName;
            }

        }
        // Save student
        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyDB())
            {
                if (isValid())
                {

                    Group group = comboBox2.SelectedItem as Group;

                    string email = textBox3.Text;
                    Student exitStd = db.Student.FirstOrDefault(em => em.Deleted == false && em.Email == email);
                    int grStudentCount = db.Student.Where(st => st.Deleted == false && st.GroupID == group.id).Count();

                    if (exitStd == null)
                    {
                        if ((grStudentCount + 1) < group.Capacity)
                        {
                            Student std = new Student()
                            {
                                Name = textBox1.Text,
                                Surname = textBox2.Text,
                                Email = email,
                                Phone = textBox4.Text,
                                Fee = Convert.ToDouble(textBox5.Text),
                                GroupID = group.id,
                                StartDate = dateTimePicker2.Value,
                                Deleted = false,
                                photo = selectedImage,
                            };

                            db.Student.Add(std);

                            if (db.SaveChanges() != 0)
                            {
                                MessageBox.Show("Student is added");
                                ClearInputs();
                            }
                            else
                            {
                                MessageBox.Show("Error: Student did not added");
                            }
                        }
                        else
                        {
                            MessageBox.Show("This group is full");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This email is alredy registered as " + exitStd.Name + " " + exitStd.Surname);
                    }
                }
            }
        }
        // fill comboboxes
        public void fillCombobox()
        {
            using (var db = new AcademyDB())
            {
                comboBox2.DataSource = db.Group.Where(g => g.Deleted == false).ToList();
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "id";
                comboBox2.SelectedIndex = -1;
            }
        }

        // Ipnut validation
        public bool isValid()
        {
            int inputCount = 1; // textboxes + combobox
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
            }

            if (comboBox2.SelectedIndex != -1)
            {
                valid++;
            }
            else
            {
                ToolTip toolTip = new ToolTip();
                toolTip.IsBalloon = true;
                toolTip.Show("Select Group to student", comboBox2, 150, -50, 2000);

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
                else if (con is DateTimePicker)
                {
                    (con as DateTimePicker).Value = DateTime.Now;
                }
            }
        }

      
    }
}
