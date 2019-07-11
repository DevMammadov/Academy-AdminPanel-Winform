using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AcademyAdminPanel.Model;

namespace AcademyAdminPanel.Forms
{
    public partial class addTaskForm : Form
    {
        public addTaskForm()
        {
            InitializeComponent();
            fillCombobox();
        }

        // Save student
        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new AcademyDB())
            {
                if (isValid())
                {

                    Group group = comboBox2.SelectedItem as Group;

                    Task task = new Task()
                    {
                        Name = textBox1.Text,
                        Dedline = dateTimePicker2.Value,
                        GroupID = group.id,
                        Deleted = false,
                    };

                    db.Task.Add(task);

                    if (db.SaveChanges() != 0)
                    {
                        MessageBox.Show("Task added");
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Error: Task did not added");
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
                toolTip.Show("Select Group to task", comboBox2, 150, -50, 2000);

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
