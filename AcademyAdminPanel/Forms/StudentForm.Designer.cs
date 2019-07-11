namespace AcademyAdminPanel.Forms
{
    partial class StudentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelSearchTextBox = new System.Windows.Forms.Panel();
            this.PanelInnerSearchTextBox = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelSeacrhButton = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.PanelSearchLineBottom = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panelFormBody = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblDeptorCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSeacrhLineTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.PanelGroupBy = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvComboboxGroup = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateTimePickerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.PanelSearchTextBox.SuspendLayout();
            this.PanelInnerSearchTextBox.SuspendLayout();
            this.PanelSeacrhButton.SuspendLayout();
            this.PanelSearchLineBottom.SuspendLayout();
            this.panelFormBody.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.PanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelSeacrhLineTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelGroupBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(399, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 44);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AcademyAdminPanel.Properties.Resources.sort_by_numeric_order;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 44);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // PanelSearchTextBox
            // 
            this.PanelSearchTextBox.Controls.Add(this.PanelInnerSearchTextBox);
            this.PanelSearchTextBox.Controls.Add(this.PanelSeacrhButton);
            this.PanelSearchTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSearchTextBox.Location = new System.Drawing.Point(0, 0);
            this.PanelSearchTextBox.Name = "PanelSearchTextBox";
            this.PanelSearchTextBox.Size = new System.Drawing.Size(399, 44);
            this.PanelSearchTextBox.TabIndex = 1;
            // 
            // PanelInnerSearchTextBox
            // 
            this.PanelInnerSearchTextBox.Controls.Add(this.textBox1);
            this.PanelInnerSearchTextBox.Location = new System.Drawing.Point(12, 10);
            this.PanelInnerSearchTextBox.Name = "PanelInnerSearchTextBox";
            this.PanelInnerSearchTextBox.Size = new System.Drawing.Size(337, 28);
            this.PanelInnerSearchTextBox.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // PanelSeacrhButton
            // 
            this.PanelSeacrhButton.Controls.Add(this.btnSearch);
            this.PanelSeacrhButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSeacrhButton.Location = new System.Drawing.Point(351, 0);
            this.PanelSeacrhButton.Name = "PanelSeacrhButton";
            this.PanelSeacrhButton.Size = new System.Drawing.Size(48, 44);
            this.PanelSeacrhButton.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::AcademyAdminPanel.Properties.Resources.magnifier;
            this.btnSearch.Location = new System.Drawing.Point(3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // PanelSearchLineBottom
            // 
            this.PanelSearchLineBottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelSearchLineBottom.Controls.Add(this.checkBox1);
            this.PanelSearchLineBottom.Controls.Add(this.dateTimePicker1);
            this.PanelSearchLineBottom.Controls.Add(this.label4);
            this.PanelSearchLineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSearchLineBottom.Location = new System.Drawing.Point(0, 45);
            this.PanelSearchLineBottom.Name = "PanelSearchLineBottom";
            this.PanelSearchLineBottom.Size = new System.Drawing.Size(1030, 50);
            this.PanelSearchLineBottom.TabIndex = 8;
            this.PanelSearchLineBottom.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.checkBox1.Location = new System.Drawing.Point(399, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Debts";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Study from";
            // 
            // panelFormBody
            // 
            this.panelFormBody.Controls.Add(this.panelBottom);
            this.panelFormBody.Controls.Add(this.PanelGrid);
            this.panelFormBody.Controls.Add(this.panelHeader);
            this.panelFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormBody.Location = new System.Drawing.Point(0, 0);
            this.panelFormBody.Name = "panelFormBody";
            this.panelFormBody.Size = new System.Drawing.Size(1030, 598);
            this.panelFormBody.TabIndex = 11;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblDeptorCount);
            this.panelBottom.Controls.Add(this.label7);
            this.panelBottom.Controls.Add(this.lblStudentCount);
            this.panelBottom.Controls.Add(this.label8);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 562);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1030, 36);
            this.panelBottom.TabIndex = 14;
            // 
            // lblDeptorCount
            // 
            this.lblDeptorCount.AutoSize = true;
            this.lblDeptorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptorCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblDeptorCount.Location = new System.Drawing.Point(228, 12);
            this.lblDeptorCount.Name = "lblDeptorCount";
            this.lblDeptorCount.Size = new System.Drawing.Size(15, 15);
            this.lblDeptorCount.TabIndex = 24;
            this.lblDeptorCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(166, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Deptor";
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblStudentCount.Location = new System.Drawing.Point(111, 11);
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
            this.label8.Location = new System.Drawing.Point(23, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Students:";
            // 
            // PanelGrid
            // 
            this.PanelGrid.Controls.Add(this.dataGridView1);
            this.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGrid.Location = new System.Drawing.Point(0, 95);
            this.PanelGrid.Name = "PanelGrid";
            this.PanelGrid.Size = new System.Drawing.Size(1030, 503);
            this.PanelGrid.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.dgvComboboxGroup,
            this.dateTimePickerColumn,
            this.dgvRemove});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 503);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grid_CellPainting);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelSeacrhLineTop);
            this.panelHeader.Controls.Add(this.PanelSearchLineBottom);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1030, 95);
            this.panelHeader.TabIndex = 9;
            // 
            // panelSeacrhLineTop
            // 
            this.panelSeacrhLineTop.Controls.Add(this.panel2);
            this.panelSeacrhLineTop.Controls.Add(this.PanelGroupBy);
            this.panelSeacrhLineTop.Controls.Add(this.panel1);
            this.panelSeacrhLineTop.Controls.Add(this.PanelSearchTextBox);
            this.panelSeacrhLineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeacrhLineTop.Location = new System.Drawing.Point(0, 0);
            this.panelSeacrhLineTop.Name = "panelSeacrhLineTop";
            this.panelSeacrhLineTop.Size = new System.Drawing.Size(1030, 44);
            this.panelSeacrhLineTop.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(868, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 44);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button3.Image = global::AcademyAdminPanel.Properties.Resources.addUSer;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(6, -6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 59);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // PanelGroupBy
            // 
            this.PanelGroupBy.Controls.Add(this.button1);
            this.PanelGroupBy.Controls.Add(this.comboBox1);
            this.PanelGroupBy.Controls.Add(this.label6);
            this.PanelGroupBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelGroupBy.Location = new System.Drawing.Point(462, 0);
            this.PanelGroupBy.Name = "PanelGroupBy";
            this.PanelGroupBy.Size = new System.Drawing.Size(406, 44);
            this.PanelGroupBy.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AcademyAdminPanel.Properties.Resources.brush1;
            this.button1.Location = new System.Drawing.Point(355, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(43, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Group";
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
            this.Column1.DataPropertyName = "onlyString";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Student Name";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "onlyString";
            this.Column2.HeaderText = "Surname";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.ToolTipText = "Student surname";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "emailType";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.ToolTipText = "Student  email";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "phoneNumber";
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.ToolTipText = "Student  phone";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "onlyDouble";
            this.Column6.HeaderText = "Fee";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.ToolTipText = "Student fee";
            // 
            // dgvComboboxGroup
            // 
            this.dgvComboboxGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvComboboxGroup.DataPropertyName = "any";
            this.dgvComboboxGroup.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvComboboxGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvComboboxGroup.HeaderText = "Group";
            this.dgvComboboxGroup.Name = "dgvComboboxGroup";
            this.dgvComboboxGroup.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComboboxGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvComboboxGroup.ToolTipText = "Student Group";
            // 
            // dateTimePickerColumn
            // 
            this.dateTimePickerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateTimePickerColumn.DataPropertyName = "any";
            this.dateTimePickerColumn.HeaderText = "Start date";
            this.dateTimePickerColumn.Name = "dateTimePickerColumn";
            this.dateTimePickerColumn.ReadOnly = true;
            this.dateTimePickerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateTimePickerColumn.ToolTipText = "Student start date";
            // 
            // dgvRemove
            // 
            this.dgvRemove.HeaderText = "Delete";
            this.dgvRemove.Name = "dgvRemove";
            this.dgvRemove.ReadOnly = true;
            this.dgvRemove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvRemove.ToolTipText = "Delete Student";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 598);
            this.Controls.Add(this.panelFormBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.panel1.ResumeLayout(false);
            this.PanelSearchTextBox.ResumeLayout(false);
            this.PanelInnerSearchTextBox.ResumeLayout(false);
            this.PanelInnerSearchTextBox.PerformLayout();
            this.PanelSeacrhButton.ResumeLayout(false);
            this.PanelSearchLineBottom.ResumeLayout(false);
            this.PanelSearchLineBottom.PerformLayout();
            this.panelFormBody.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.PanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelSeacrhLineTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelGroupBy.ResumeLayout(false);
            this.PanelGroupBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PanelSearchTextBox;
        private System.Windows.Forms.Panel PanelInnerSearchTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelSeacrhButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel PanelSearchLineBottom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelFormBody;
        private System.Windows.Forms.Panel PanelGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSeacrhLineTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PanelGroupBy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblDeptorCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvComboboxGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimePickerColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dgvRemove;
    }
}