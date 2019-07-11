using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyAdminPanel.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Employers button
        private void btnEmployer_Click(object sender, EventArgs e)
        {
            openSection(new EmployerForm());
            btnEmployer.BackColor = Color.FromArgb(45, 45, 48);
        }

        // Students button
        private void btnStudent_Click(object sender, EventArgs e)
        {
            openSection(new StudentForm());
            btnStudent.BackColor = Color.FromArgb(45, 45, 48);
        }
        // Group form
        private void btnGroup_Click(object sender, EventArgs e)
        {
            
            openSection(new GroupForm());
            btnGroup.BackColor = Color.FromArgb(45, 45, 48);
        }

        // Task button
        private void btnTask_Click(object sender, EventArgs e)
        {
            openSection(new TaskForm());
            btnTask.BackColor = Color.FromArgb(45, 45, 48);
        }
        // Academy form
        private void btnAcademy_Click(object sender, EventArgs e)
        {
            openSection(new AcademyForm());
            btnAcademy.BackColor = Color.FromArgb(45, 45, 48);
        }
        // method form opener
        public void openSection(object form)
        {

            if (FormBody.Controls.Count > 0)
            {
                FormBody.Controls.RemoveAt(0);
            }

            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            FormBody.Controls.Add(frm);
            FormBody.Tag = frm;
            frm.Show();

            resetButtonColor();
        }

        // button color reset
        public void resetButtonColor()
        {
            foreach(Control c in VerticalMenu.Controls)
            {
                if(c is Button)
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);
                }
            }
        }


    //menu collapse button
    private void btnMenuCollapse_Click(object sender, EventArgs e)
        {
            if(VerticalMenu.Width > 70)
            {
                VerticalMenu.Width = 70;
            }
            else
            {
                VerticalMenu.Width = 185;
            }
        }

        // Close button
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // minimize button
        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // maximaze icon
        private void button8_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        // Form move
        bool TogMove;
        int MValX;
        int MValY;
        private void FormTitle_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            if (VerticalMenu.Width > 70)
            {
                MValX = e.X + 190;
            }
            else
            {
                MValX = e.X + 70;
            }
            MValY = e.Y;
        }

        private void FormTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void FormTitle_MouseUp_1(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }
    }
}
