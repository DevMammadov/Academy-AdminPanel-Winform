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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            loadInfo();
        }

        // Load information from DB on form loading
        public void loadInfo()
        {
            using(var db = new AcademyDB())
            {
                AcademyInfo info = db.AcademyInfo.FirstOrDefault();
                if(info != null)
                {
                    textBox1.Text = info.Name;
                    textBox2.Text = info.Phone;
                    textBox3.Text = info.Address;
                    richTextBox1.Text = info.About;

                    button1.Text = "Update info";
                }
                else
                {
                    button1.Text = "Add info";
                }
            }
        }

        // Update  or add info
        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new AcademyDB())
            {
                if (isValid())
                {
                    // if table is not empty
                    if (db.AcademyInfo.Any())
                    {
                        
                            AcademyInfo info = db.AcademyInfo.FirstOrDefault(i => i.Name != null);
                            info.Name = textBox1.Text;
                            info.Phone = textBox2.Text;
                            info.Address = textBox3.Text;
                            info.About = richTextBox1.Text;
                        try
                        {
                            if (db.SaveChanges() != 0)
                            {
                                MessageBox.Show("information updated");
                                ClearInputs();
                                loadInfo();
                            }
                            else
                            {
                                MessageBox.Show("Error: Information did not updated");
                            }
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException exp)
                        {
                            foreach (var eve in exp.EntityValidationErrors)
                            {
                                Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                    eve.Entry.Entity.GetType().Name, eve.Entry.State);
                                foreach (var ve in eve.ValidationErrors)
                                {
                                    Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                        ve.PropertyName, ve.ErrorMessage);
                                }
                            }
                        
                        }
                    }
                    else
                    {
                        AcademyInfo newInfo = new AcademyInfo()
                        {
                            Name = textBox1.Text,
                            Phone = textBox2.Text,
                            Address = textBox3.Text,
                            About = richTextBox1.Text,
                        };

                        db.AcademyInfo.Add(newInfo);

                        if (db.SaveChanges() != 0)
                        {
                            MessageBox.Show("information added");
                            ClearInputs();
                            loadInfo();
                        }
                        else
                        {
                            MessageBox.Show("Error: Information did not added");
                        }
                    }
                }
            }
        }

        // Ipnut validation
        public bool isValid()
        {
            int inputCount = 0;
            int valid = 0;
            foreach (Control con in Controls)
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

            if (valid == inputCount)
            {
                return true;
            }
            else return false;
        }

        // Clear inputs
        public void ClearInputs()
        {
            foreach (Control con in Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
                else if(con is RichTextBox)
                {
                    con.Text = string.Empty;
                }
            }
        }
    }
}
