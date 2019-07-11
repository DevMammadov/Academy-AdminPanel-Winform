namespace AcademyAdminPanel.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.VerticalMenu = new System.Windows.Forms.Panel();
            this.FormTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FormBody = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnMenuCollapse = new System.Windows.Forms.PictureBox();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnAcademy = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnEmployer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VerticalMenu.SuspendLayout();
            this.FormTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuCollapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // VerticalMenu
            // 
            this.VerticalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.VerticalMenu.Controls.Add(this.btnGroup);
            this.VerticalMenu.Controls.Add(this.btnAcademy);
            this.VerticalMenu.Controls.Add(this.btnTask);
            this.VerticalMenu.Controls.Add(this.btnStudent);
            this.VerticalMenu.Controls.Add(this.btnEmployer);
            this.VerticalMenu.Controls.Add(this.pictureBox2);
            this.VerticalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.VerticalMenu.Location = new System.Drawing.Point(0, 0);
            this.VerticalMenu.Name = "VerticalMenu";
            this.VerticalMenu.Size = new System.Drawing.Size(250, 649);
            this.VerticalMenu.TabIndex = 0;
            // 
            // FormTitle
            // 
            this.FormTitle.Controls.Add(this.panel1);
            this.FormTitle.Controls.Add(this.btnMenuCollapse);
            this.FormTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormTitle.Location = new System.Drawing.Point(250, 0);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(1030, 51);
            this.FormTitle.TabIndex = 1;
            this.FormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTitle_MouseDown);
            this.FormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormTitle_MouseMove);
            this.FormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormTitle_MouseUp_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(923, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 51);
            this.panel1.TabIndex = 11;
            // 
            // FormBody
            // 
            this.FormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormBody.Location = new System.Drawing.Point(250, 51);
            this.FormBody.Name = "FormBody";
            this.FormBody.Size = new System.Drawing.Size(1030, 598);
            this.FormBody.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button7.Image = global::AcademyAdminPanel.Properties.Resources.minimizew;
            this.button7.Location = new System.Drawing.Point(40, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 28);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button8.Image = global::AcademyAdminPanel.Properties.Resources.maximizewm;
            this.button8.Location = new System.Drawing.Point(4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 28);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button6.Image = global::AcademyAdminPanel.Properties.Resources.closeww;
            this.button6.Location = new System.Drawing.Point(76, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 28);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnMenuCollapse
            // 
            this.btnMenuCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCollapse.Image = global::AcademyAdminPanel.Properties.Resources.formimage;
            this.btnMenuCollapse.Location = new System.Drawing.Point(6, 9);
            this.btnMenuCollapse.Name = "btnMenuCollapse";
            this.btnMenuCollapse.Size = new System.Drawing.Size(35, 35);
            this.btnMenuCollapse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenuCollapse.TabIndex = 0;
            this.btnMenuCollapse.TabStop = false;
            this.btnMenuCollapse.Click += new System.EventHandler(this.btnMenuCollapse_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGroup.Image = global::AcademyAdminPanel.Properties.Resources.group;
            this.btnGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroup.Location = new System.Drawing.Point(0, 273);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(250, 75);
            this.btnGroup.TabIndex = 4;
            this.btnGroup.Text = "        Groups";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnAcademy
            // 
            this.btnAcademy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcademy.FlatAppearance.BorderSize = 0;
            this.btnAcademy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAcademy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAcademy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcademy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcademy.Image = global::AcademyAdminPanel.Properties.Resources.settings;
            this.btnAcademy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcademy.Location = new System.Drawing.Point(0, 435);
            this.btnAcademy.Name = "btnAcademy";
            this.btnAcademy.Size = new System.Drawing.Size(250, 75);
            this.btnAcademy.TabIndex = 5;
            this.btnAcademy.Text = "           Academy";
            this.btnAcademy.UseVisualStyleBackColor = true;
            this.btnAcademy.Click += new System.EventHandler(this.btnAcademy_Click);
            // 
            // btnTask
            // 
            this.btnTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTask.FlatAppearance.BorderSize = 0;
            this.btnTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTask.Image = global::AcademyAdminPanel.Properties.Resources.task;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.Location = new System.Drawing.Point(0, 354);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(250, 75);
            this.btnTask.TabIndex = 3;
            this.btnTask.Text = "      Tasks";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudent.Image = global::AcademyAdminPanel.Properties.Resources.student;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 192);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(250, 75);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "          Students";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnEmployer
            // 
            this.btnEmployer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployer.FlatAppearance.BorderSize = 0;
            this.btnEmployer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEmployer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEmployer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployer.Image = global::AcademyAdminPanel.Properties.Resources.employee;
            this.btnEmployer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployer.Location = new System.Drawing.Point(0, 111);
            this.btnEmployer.Name = "btnEmployer";
            this.btnEmployer.Size = new System.Drawing.Size(250, 75);
            this.btnEmployer.TabIndex = 1;
            this.btnEmployer.Text = "              Employers";
            this.btnEmployer.UseVisualStyleBackColor = true;
            this.btnEmployer.Click += new System.EventHandler(this.btnEmployer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 649);
            this.Controls.Add(this.FormBody);
            this.Controls.Add(this.FormTitle);
            this.Controls.Add(this.VerticalMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.VerticalMenu.ResumeLayout(false);
            this.FormTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuCollapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VerticalMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel FormTitle;
        private System.Windows.Forms.PictureBox btnMenuCollapse;
        private System.Windows.Forms.Button btnEmployer;
        private System.Windows.Forms.Button btnAcademy;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel FormBody;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
    }
}