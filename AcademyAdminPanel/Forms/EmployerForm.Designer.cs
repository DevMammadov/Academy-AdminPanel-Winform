namespace AcademyAdminPanel.Forms
{
    partial class EmployerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCombobox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvComboboxSp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSeacrhLineTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.PanelGroupBy = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelSearchTextBox = new System.Windows.Forms.Panel();
            this.PanelInnerSearchTextBox = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelSeacrhButton = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.PanelSearchLineBottom = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxSalary = new System.Windows.Forms.NumericUpDown();
            this.txtMinSalary = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFormBody = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblFreeTeacher = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSelectedPosition = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEmployers = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelSeacrhLineTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelGroupBy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelSearchTextBox.SuspendLayout();
            this.PanelInnerSearchTextBox.SuspendLayout();
            this.PanelSeacrhButton.SuspendLayout();
            this.PanelSearchLineBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinSalary)).BeginInit();
            this.panelFormBody.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvCombobox,
            this.Column6,
            this.dateTimePickerColumn,
            this.dgvComboboxSp,
            this.Column4});
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
            this.Column1.ToolTipText = "Employee Name";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "onlyString";
            this.Column2.HeaderText = "Surname";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.ToolTipText = "Employee surname";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "emailType";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.ToolTipText = "Employee  email";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "phoneNumber";
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.ToolTipText = "Employee  phone";
            // 
            // dgvCombobox
            // 
            this.dgvCombobox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCombobox.DataPropertyName = "any";
            this.dgvCombobox.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvCombobox.HeaderText = "Position";
            this.dgvCombobox.MaxDropDownItems = 5;
            this.dgvCombobox.Name = "dgvCombobox";
            this.dgvCombobox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCombobox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvCombobox.ToolTipText = "Employee position";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "onlyDouble";
            this.Column6.HeaderText = "Salary";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.ToolTipText = "Employee salary";
            // 
            // dateTimePickerColumn
            // 
            this.dateTimePickerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateTimePickerColumn.HeaderText = "Start time";
            this.dateTimePickerColumn.Name = "dateTimePickerColumn";
            this.dateTimePickerColumn.ReadOnly = true;
            this.dateTimePickerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateTimePickerColumn.ToolTipText = "Employee start time";
            // 
            // dgvComboboxSp
            // 
            this.dgvComboboxSp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvComboboxSp.DataPropertyName = "all";
            this.dgvComboboxSp.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvComboboxSp.HeaderText = "Speciality";
            this.dgvComboboxSp.Name = "dgvComboboxSp";
            this.dgvComboboxSp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComboboxSp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvComboboxSp.ToolTipText = "Employee speciality";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dgvRemove";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Delete";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.ToolTipText = "Delete employee";
            this.Column4.Width = 50;
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
            this.panel2.Location = new System.Drawing.Point(796, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 44);
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
            this.button3.Location = new System.Drawing.Point(80, -6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 59);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PanelGroupBy
            // 
            this.PanelGroupBy.Controls.Add(this.button1);
            this.PanelGroupBy.Controls.Add(this.comboBox1);
            this.PanelGroupBy.Controls.Add(this.label1);
            this.PanelGroupBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelGroupBy.Location = new System.Drawing.Point(462, 0);
            this.PanelGroupBy.Name = "PanelGroupBy";
            this.PanelGroupBy.Size = new System.Drawing.Size(334, 44);
            this.PanelGroupBy.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AcademyAdminPanel.Properties.Resources.brush1;
            this.button1.Location = new System.Drawing.Point(292, 8);
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
            this.comboBox1.Location = new System.Drawing.Point(118, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position";
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.btnSearch.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PanelSearchLineBottom
            // 
            this.PanelSearchLineBottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelSearchLineBottom.Controls.Add(this.comboBox2);
            this.PanelSearchLineBottom.Controls.Add(this.label5);
            this.PanelSearchLineBottom.Controls.Add(this.txtMaxSalary);
            this.PanelSearchLineBottom.Controls.Add(this.txtMinSalary);
            this.PanelSearchLineBottom.Controls.Add(this.dateTimePicker1);
            this.PanelSearchLineBottom.Controls.Add(this.label4);
            this.PanelSearchLineBottom.Controls.Add(this.label3);
            this.PanelSearchLineBottom.Controls.Add(this.label2);
            this.PanelSearchLineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSearchLineBottom.Location = new System.Drawing.Point(0, 45);
            this.PanelSearchLineBottom.Name = "PanelSearchLineBottom";
            this.PanelSearchLineBottom.Size = new System.Drawing.Size(1030, 50);
            this.PanelSearchLineBottom.TabIndex = 8;
            this.PanelSearchLineBottom.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(856, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 26);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(751, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Speciality";
            // 
            // txtMaxSalary
            // 
            this.txtMaxSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMaxSalary.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtMaxSalary.Location = new System.Drawing.Point(263, 11);
            this.txtMaxSalary.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txtMaxSalary.Name = "txtMaxSalary";
            this.txtMaxSalary.Size = new System.Drawing.Size(60, 22);
            this.txtMaxSalary.TabIndex = 5;
            this.txtMaxSalary.ValueChanged += new System.EventHandler(this.txtMinSalary_TextChanged);
            // 
            // txtMinSalary
            // 
            this.txtMinSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMinSalary.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtMinSalary.Location = new System.Drawing.Point(171, 11);
            this.txtMinSalary.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txtMinSalary.Name = "txtMinSalary";
            this.txtMinSalary.Size = new System.Drawing.Size(60, 22);
            this.txtMinSalary.TabIndex = 1;
            this.txtMinSalary.ValueChanged += new System.EventHandler(this.txtMinSalary_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(473, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(351, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Working from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(237, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salary between";
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
            this.panelFormBody.TabIndex = 10;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblFreeTeacher);
            this.panelBottom.Controls.Add(this.label9);
            this.panelBottom.Controls.Add(this.lblSelectedPosition);
            this.panelBottom.Controls.Add(this.label8);
            this.panelBottom.Controls.Add(this.lblEmployers);
            this.panelBottom.Controls.Add(this.label6);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 562);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1030, 36);
            this.panelBottom.TabIndex = 13;
            // 
            // lblFreeTeacher
            // 
            this.lblFreeTeacher.AutoSize = true;
            this.lblFreeTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblFreeTeacher.Location = new System.Drawing.Point(260, 13);
            this.lblFreeTeacher.Name = "lblFreeTeacher";
            this.lblFreeTeacher.Size = new System.Drawing.Size(15, 15);
            this.lblFreeTeacher.TabIndex = 19;
            this.lblFreeTeacher.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(151, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Free Teachers:";
            // 
            // lblSelectedPosition
            // 
            this.lblSelectedPosition.AutoSize = true;
            this.lblSelectedPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblSelectedPosition.Location = new System.Drawing.Point(429, 12);
            this.lblSelectedPosition.Name = "lblSelectedPosition";
            this.lblSelectedPosition.Size = new System.Drawing.Size(33, 15);
            this.lblSelectedPosition.TabIndex = 17;
            this.lblSelectedPosition.Text = "Null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(296, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Selected position";
            // 
            // lblEmployers
            // 
            this.lblEmployers.AutoSize = true;
            this.lblEmployers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblEmployers.Location = new System.Drawing.Point(101, 13);
            this.lblEmployers.Name = "lblEmployers";
            this.lblEmployers.Size = new System.Drawing.Size(15, 15);
            this.lblEmployers.TabIndex = 15;
            this.lblEmployers.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Employers:";
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 598);
            this.Controls.Add(this.panelFormBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployerForm";
            this.Text = "PositionForm";
            this.PanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelSeacrhLineTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelGroupBy.ResumeLayout(false);
            this.PanelGroupBy.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelSearchTextBox.ResumeLayout(false);
            this.PanelInnerSearchTextBox.ResumeLayout(false);
            this.PanelInnerSearchTextBox.PerformLayout();
            this.PanelSeacrhButton.ResumeLayout(false);
            this.PanelSearchLineBottom.ResumeLayout(false);
            this.PanelSearchLineBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinSalary)).EndInit();
            this.panelFormBody.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelGrid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSeacrhLineTop;
        private System.Windows.Forms.Panel PanelSearchTextBox;
        private System.Windows.Forms.Panel PanelInnerSearchTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelSeacrhButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel PanelGroupBy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelSearchLineBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtMinSalary;
        private System.Windows.Forms.NumericUpDown txtMaxSalary;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelFormBody;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblSelectedPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmployers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvCombobox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimePickerColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvComboboxSp;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Label lblFreeTeacher;
        private System.Windows.Forms.Label label9;
    }
}