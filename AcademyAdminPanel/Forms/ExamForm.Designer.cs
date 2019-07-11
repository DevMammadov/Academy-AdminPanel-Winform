namespace AcademyAdminPanel.Forms
{
    partial class ExamForm
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
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFormBody = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblWithoutPoint = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaxPoint = new System.Windows.Forms.Label();
            this.lblExellantStudent = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAveragePoint = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurrentTask = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSeacrhLineTop = new System.Windows.Forms.Panel();
            this.panelHeaderTop = new System.Windows.Forms.Panel();
            this.panelAddButton = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.PanelSearchTextBox = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelSortButton = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelGroupBy = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelSearchLineBottom = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFormBody.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSeacrhLineTop.SuspendLayout();
            this.panelHeaderTop.SuspendLayout();
            this.panelAddButton.SuspendLayout();
            this.PanelSearchTextBox.SuspendLayout();
            this.panelSortButton.SuspendLayout();
            this.PanelGroupBy.SuspendLayout();
            this.PanelSearchLineBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridView1);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 95);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1012, 456);
            this.panelGrid.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "any";
            this.Column1.HeaderText = "Student";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Employee Name";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Task";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.ToolTipText = "Task Dedline";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "onlyNumber";
            this.Column2.HeaderText = "Point";
            this.Column2.Name = "Column2";
            // 
            // panelFormBody
            // 
            this.panelFormBody.Controls.Add(this.panelBottom);
            this.panelFormBody.Controls.Add(this.panelGrid);
            this.panelFormBody.Controls.Add(this.panelHeader);
            this.panelFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormBody.Location = new System.Drawing.Point(0, 0);
            this.panelFormBody.Name = "panelFormBody";
            this.panelFormBody.Size = new System.Drawing.Size(1012, 551);
            this.panelFormBody.TabIndex = 12;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblWithoutPoint);
            this.panelBottom.Controls.Add(this.label7);
            this.panelBottom.Controls.Add(this.lblMaxPoint);
            this.panelBottom.Controls.Add(this.lblExellantStudent);
            this.panelBottom.Controls.Add(this.label12);
            this.panelBottom.Controls.Add(this.lblAveragePoint);
            this.panelBottom.Controls.Add(this.label10);
            this.panelBottom.Controls.Add(this.lblStudentCount);
            this.panelBottom.Controls.Add(this.label8);
            this.panelBottom.Controls.Add(this.lblCurrentTask);
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 515);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1012, 36);
            this.panelBottom.TabIndex = 12;
            // 
            // lblWithoutPoint
            // 
            this.lblWithoutPoint.AutoSize = true;
            this.lblWithoutPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithoutPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblWithoutPoint.Location = new System.Drawing.Point(472, 9);
            this.lblWithoutPoint.Name = "lblWithoutPoint";
            this.lblWithoutPoint.Size = new System.Drawing.Size(15, 15);
            this.lblWithoutPoint.TabIndex = 24;
            this.lblWithoutPoint.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(357, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Without points:";
            // 
            // lblMaxPoint
            // 
            this.lblMaxPoint.AutoSize = true;
            this.lblMaxPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblMaxPoint.Location = new System.Drawing.Point(952, 9);
            this.lblMaxPoint.Name = "lblMaxPoint";
            this.lblMaxPoint.Size = new System.Drawing.Size(0, 15);
            this.lblMaxPoint.TabIndex = 22;
            // 
            // lblExellantStudent
            // 
            this.lblExellantStudent.AutoSize = true;
            this.lblExellantStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExellantStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblExellantStudent.Location = new System.Drawing.Point(809, 9);
            this.lblExellantStudent.Name = "lblExellantStudent";
            this.lblExellantStudent.Size = new System.Drawing.Size(31, 15);
            this.lblExellantStudent.TabIndex = 21;
            this.lblExellantStudent.Text = "null";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(682, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Exellant student:";
            // 
            // lblAveragePoint
            // 
            this.lblAveragePoint.AutoSize = true;
            this.lblAveragePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveragePoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblAveragePoint.Location = new System.Drawing.Point(635, 9);
            this.lblAveragePoint.Name = "lblAveragePoint";
            this.lblAveragePoint.Size = new System.Drawing.Size(15, 15);
            this.lblAveragePoint.TabIndex = 19;
            this.lblAveragePoint.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(520, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Average point:";
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblStudentCount.Location = new System.Drawing.Point(323, 9);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(15, 15);
            this.lblStudentCount.TabIndex = 17;
            this.lblStudentCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(209, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Student count:";
            // 
            // lblCurrentTask
            // 
            this.lblCurrentTask.AutoSize = true;
            this.lblCurrentTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblCurrentTask.Location = new System.Drawing.Point(108, 9);
            this.lblCurrentTask.Name = "lblCurrentTask";
            this.lblCurrentTask.Size = new System.Drawing.Size(31, 15);
            this.lblCurrentTask.TabIndex = 15;
            this.lblCurrentTask.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Current task:";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelSeacrhLineTop);
            this.panelHeader.Controls.Add(this.PanelSearchLineBottom);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1012, 95);
            this.panelHeader.TabIndex = 10;
            // 
            // panelSeacrhLineTop
            // 
            this.panelSeacrhLineTop.Controls.Add(this.panelHeaderTop);
            this.panelSeacrhLineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeacrhLineTop.Location = new System.Drawing.Point(0, 0);
            this.panelSeacrhLineTop.Name = "panelSeacrhLineTop";
            this.panelSeacrhLineTop.Size = new System.Drawing.Size(1012, 44);
            this.panelSeacrhLineTop.TabIndex = 6;
            // 
            // panelHeaderTop
            // 
            this.panelHeaderTop.Controls.Add(this.panelAddButton);
            this.panelHeaderTop.Controls.Add(this.PanelSearchTextBox);
            this.panelHeaderTop.Controls.Add(this.panelSortButton);
            this.panelHeaderTop.Controls.Add(this.PanelGroupBy);
            this.panelHeaderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderTop.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderTop.Name = "panelHeaderTop";
            this.panelHeaderTop.Size = new System.Drawing.Size(1012, 44);
            this.panelHeaderTop.TabIndex = 0;
            // 
            // panelAddButton
            // 
            this.panelAddButton.Controls.Add(this.button3);
            this.panelAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddButton.Location = new System.Drawing.Point(0, 0);
            this.panelAddButton.Name = "panelAddButton";
            this.panelAddButton.Size = new System.Drawing.Size(144, 44);
            this.panelAddButton.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button3.Image = global::AcademyAdminPanel.Properties.Resources.back_arrow;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PanelSearchTextBox
            // 
            this.PanelSearchTextBox.Controls.Add(this.btnSearch);
            this.PanelSearchTextBox.Controls.Add(this.textBox1);
            this.PanelSearchTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSearchTextBox.Location = new System.Drawing.Point(144, 0);
            this.PanelSearchTextBox.Name = "PanelSearchTextBox";
            this.PanelSearchTextBox.Size = new System.Drawing.Size(264, 44);
            this.PanelSearchTextBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::AcademyAdminPanel.Properties.Resources.magnifier;
            this.btnSearch.Location = new System.Drawing.Point(220, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelSortButton
            // 
            this.panelSortButton.Controls.Add(this.button2);
            this.panelSortButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSortButton.Location = new System.Drawing.Point(408, 0);
            this.panelSortButton.Name = "panelSortButton";
            this.panelSortButton.Size = new System.Drawing.Size(46, 44);
            this.panelSortButton.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AcademyAdminPanel.Properties.Resources.sort_by_numeric_order;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 44);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PanelGroupBy
            // 
            this.PanelGroupBy.Controls.Add(this.comboBox2);
            this.PanelGroupBy.Controls.Add(this.label2);
            this.PanelGroupBy.Controls.Add(this.button1);
            this.PanelGroupBy.Controls.Add(this.comboBox1);
            this.PanelGroupBy.Controls.Add(this.label6);
            this.PanelGroupBy.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelGroupBy.Location = new System.Drawing.Point(454, 0);
            this.PanelGroupBy.Name = "PanelGroupBy";
            this.PanelGroupBy.Size = new System.Drawing.Size(558, 44);
            this.PanelGroupBy.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 26);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Group";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AcademyAdminPanel.Properties.Resources.brush1;
            this.button1.Location = new System.Drawing.Point(517, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(259, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tasks";
            // 
            // PanelSearchLineBottom
            // 
            this.PanelSearchLineBottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelSearchLineBottom.Controls.Add(this.comboBox3);
            this.PanelSearchLineBottom.Controls.Add(this.label3);
            this.PanelSearchLineBottom.Controls.Add(this.checkBox4);
            this.PanelSearchLineBottom.Controls.Add(this.checkBox3);
            this.PanelSearchLineBottom.Controls.Add(this.numericUpDown2);
            this.PanelSearchLineBottom.Controls.Add(this.numericUpDown1);
            this.PanelSearchLineBottom.Controls.Add(this.label1);
            this.PanelSearchLineBottom.Controls.Add(this.label4);
            this.PanelSearchLineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSearchLineBottom.Location = new System.Drawing.Point(0, 45);
            this.PanelSearchLineBottom.Name = "PanelSearchLineBottom";
            this.PanelSearchLineBottom.Size = new System.Drawing.Size(1012, 50);
            this.PanelSearchLineBottom.TabIndex = 8;
            this.PanelSearchLineBottom.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Lower average",
            "Upper average",
            "All"});
            this.comboBox3.Location = new System.Drawing.Point(806, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 26);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(725, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sort by";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.checkBox4.Location = new System.Drawing.Point(393, 13);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(148, 24);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "without points";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.checkBox3.Location = new System.Drawing.Point(573, 13);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 24);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "only point";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(292, 14);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(74, 22);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(192, 14);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(272, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(24, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Evaluations between";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 551);
            this.Controls.Add(this.panelFormBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFormBody.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelSeacrhLineTop.ResumeLayout(false);
            this.panelHeaderTop.ResumeLayout(false);
            this.panelAddButton.ResumeLayout(false);
            this.PanelSearchTextBox.ResumeLayout(false);
            this.PanelSearchTextBox.PerformLayout();
            this.panelSortButton.ResumeLayout(false);
            this.PanelGroupBy.ResumeLayout(false);
            this.PanelGroupBy.PerformLayout();
            this.PanelSearchLineBottom.ResumeLayout(false);
            this.PanelSearchLineBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panelFormBody;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSeacrhLineTop;
        private System.Windows.Forms.Panel panelHeaderTop;
        private System.Windows.Forms.Panel panelAddButton;
        private System.Windows.Forms.Panel PanelGroupBy;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelSortButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PanelSearchTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelSearchLineBottom;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblMaxPoint;
        private System.Windows.Forms.Label lblExellantStudent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAveragePoint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurrentTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblWithoutPoint;
        private System.Windows.Forms.Label label7;
    }
}