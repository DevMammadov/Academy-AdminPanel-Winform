using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyAdminPanel.Controls
{
    public partial class Notification : UserControl
    {
        public Notification(string text, string type)
        {
            InitializeComponent();
            showNotification(text, type);
            TabIndex = 99;
         
        }

        public void showNotification(string notMessage, string notType)
        {
            switch (notType)
            {
                case "success":
                    BackColor = Color.FromArgb(40, 167, 69);
                    pictureBox1.Image = new Bitmap(Properties.Resources.success);
                    break;
                case "warning":
                    BackColor = Color.FromArgb(255, 193, 7);
                    pictureBox1.Image = new Bitmap(Properties.Resources.info);
                    break;
                case "error":
                    BackColor = Color.FromArgb(220, 53, 69);
                    pictureBox1.Image = new Bitmap(Properties.Resources.dangerous);
                    break;
                default:
                    BackColor = Color.Blue;
                    pictureBox1.Image = new Bitmap(Properties.Resources.info);
                    break;
            }

            label1.Text = notMessage;
            Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
