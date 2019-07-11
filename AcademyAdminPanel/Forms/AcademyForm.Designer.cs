namespace AcademyAdminPanel.Forms
{
    partial class AcademyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPositionTab = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelProgramTab = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelClassroomTab = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelPositionTab.SuspendLayout();
            this.panelProgramTab.SuspendLayout();
            this.panelClassroomTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelMenu.Controls.Add(this.panelInfo);
            this.panelMenu.Controls.Add(this.panelPositionTab);
            this.panelMenu.Controls.Add(this.panelProgramTab);
            this.panelMenu.Controls.Add(this.panelClassroomTab);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1030, 41);
            this.panelMenu.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInfo.Location = new System.Drawing.Point(786, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(244, 41);
            this.panelInfo.TabIndex = 4;
            this.panelInfo.Click += new System.EventHandler(this.panelInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Academy info";
            this.label3.Click += new System.EventHandler(this.panelInfo_Click);
            // 
            // panelPositionTab
            // 
            this.panelPositionTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPositionTab.Controls.Add(this.label4);
            this.panelPositionTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPositionTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPositionTab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPositionTab.Location = new System.Drawing.Point(524, 0);
            this.panelPositionTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelPositionTab.Name = "panelPositionTab";
            this.panelPositionTab.Size = new System.Drawing.Size(262, 41);
            this.panelPositionTab.TabIndex = 3;
            this.panelPositionTab.Click += new System.EventHandler(this.panelPositionTab_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Position";
            this.label4.Click += new System.EventHandler(this.panelPositionTab_Click);
            // 
            // panelProgramTab
            // 
            this.panelProgramTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProgramTab.Controls.Add(this.label2);
            this.panelProgramTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelProgramTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProgramTab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelProgramTab.Location = new System.Drawing.Point(262, 0);
            this.panelProgramTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelProgramTab.Name = "panelProgramTab";
            this.panelProgramTab.Size = new System.Drawing.Size(262, 41);
            this.panelProgramTab.TabIndex = 1;
            this.panelProgramTab.Click += new System.EventHandler(this.panelProgramTab_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Programs";
            this.label2.Click += new System.EventHandler(this.panelProgramTab_Click);
            // 
            // panelClassroomTab
            // 
            this.panelClassroomTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClassroomTab.Controls.Add(this.label1);
            this.panelClassroomTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelClassroomTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelClassroomTab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelClassroomTab.Location = new System.Drawing.Point(0, 0);
            this.panelClassroomTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelClassroomTab.Name = "panelClassroomTab";
            this.panelClassroomTab.Size = new System.Drawing.Size(262, 41);
            this.panelClassroomTab.TabIndex = 1;
            this.panelClassroomTab.Click += new System.EventHandler(this.panelClassroomTab_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classrooms";
            this.label1.Click += new System.EventHandler(this.panelClassroomTab_Paint);
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 41);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1030, 557);
            this.panelBody.TabIndex = 1;
            // 
            // AcademyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 598);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcademyForm";
            this.Text = "AcademyForm";
            this.panelMenu.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelPositionTab.ResumeLayout(false);
            this.panelPositionTab.PerformLayout();
            this.panelProgramTab.ResumeLayout(false);
            this.panelProgramTab.PerformLayout();
            this.panelClassroomTab.ResumeLayout(false);
            this.panelClassroomTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPositionTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelProgramTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelClassroomTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBody;
    }
}