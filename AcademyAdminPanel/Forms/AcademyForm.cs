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
    public partial class AcademyForm : Form
    {
        public AcademyForm()
        {
            InitializeComponent();
            openFirst();
        }

        // open first tab
        public void openFirst()
        {
            openSection(new ClassroomsForm());
            label1.ForeColor = Color.FromArgb(0, 122, 204);
            panelClassroomTab.BackColor = Color.FromArgb(240, 240, 240);
        }

        // Classroom tab
        private void panelClassroomTab_Paint(object sender, EventArgs e)
        {
            openFirst();
        }

        // Program tab
        private void panelProgramTab_Click(object sender, EventArgs e)
        {
            openSection(new ProgramsForm());
            label2.ForeColor = Color.FromArgb(0, 122, 204);
            panelProgramTab.BackColor = Color.FromArgb(240, 240, 240);
        }
        // Position tab
        private void panelPositionTab_Click(object sender, EventArgs e)
        {
            openSection(new PositionForm());
            label4.ForeColor = Color.FromArgb(0, 122, 204);
            panelPositionTab.BackColor = Color.FromArgb(240, 240, 240);
        }

        // Info tab
        private void panelInfo_Click(object sender, EventArgs e)
        {
            openSection(new InfoForm());
            label3.ForeColor = Color.FromArgb(0, 122, 204);
            panelInfo.BackColor = Color.FromArgb(240, 240, 240);
        }

        // method form opener
        public void openSection(object form)
        {

            if (panelBody.Controls.Count > 0)
            {
                panelBody.Controls.RemoveAt(0);
            }

            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(frm);
            panelBody.Tag = frm;
            frm.Show();

            resetButtonColor();
        }

        // button color reset
        public void resetButtonColor()
        {
            foreach (Control c in panelMenu.Controls)
            {
                if (c is Panel)
                {
                    c.BackColor = Color.FromArgb(0, 122, 204);
                    c.Controls[0].ForeColor = Color.White;
                }
            }
           
        }


    }
}
