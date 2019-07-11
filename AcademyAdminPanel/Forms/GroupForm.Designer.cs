namespace AcademyAdminPanel.Forms
{
    partial class GroupForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.PanelGroupBy = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panelAddbutton = new System.Windows.Forms.Panel();
            this.panelSeacrhLineTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelSearchTextBox = new System.Windows.Forms.Panel();
            this.PanelInnerSearchTextBox = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelSeacrhButton = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbClassroom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbTeacher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbMentor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProgram = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelFormBody = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblSelectedGroup = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBiggerGroup = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWithoutMentor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblWithoutTeacher = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGroupCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelGrid = new System.Windows.Forms.Panel();
            this.PanelGroupBy.SuspendLayout();
            this.panelAddbutton.SuspendLayout();
            this.panelSeacrhLineTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelSearchTextBox.SuspendLayout();
            this.PanelInnerSearchTextBox.SuspendLayout();
            this.PanelSeacrhButton.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFormBody.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.PanelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(45, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "By program";
            // 
            // PanelGroupBy
            // 
            this.PanelGroupBy.Controls.Add(this.comboBox1);
            this.PanelGroupBy.Controls.Add(this.label6);
            this.PanelGroupBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelGroupBy.Location = new System.Drawing.Point(399, 0);
            this.PanelGroupBy.Name = "PanelGroupBy";
            this.PanelGroupBy.Size = new System.Drawing.Size(365, 44);
            this.PanelGroupBy.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.button3.Location = new System.Drawing.Point(3, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelAddbutton
            // 
            this.panelAddbutton.Controls.Add(this.button3);
            this.panelAddbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddbutton.Location = new System.Drawing.Point(907, 0);
            this.panelAddbutton.Name = "panelAddbutton";
            this.panelAddbutton.Size = new System.Drawing.Size(123, 44);
            this.panelAddbutton.TabIndex = 1;
            // 
            // panelSeacrhLineTop
            // 
            this.panelSeacrhLineTop.Controls.Add(this.panelAddbutton);
            this.panelSeacrhLineTop.Controls.Add(this.panel1);
            this.panelSeacrhLineTop.Controls.Add(this.PanelGroupBy);
            this.panelSeacrhLineTop.Controls.Add(this.PanelSearchTextBox);
            this.panelSeacrhLineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeacrhLineTop.Location = new System.Drawing.Point(0, 0);
            this.panelSeacrhLineTop.Name = "panelSeacrhLineTop";
            this.panelSeacrhLineTop.Size = new System.Drawing.Size(1030, 44);
            this.panelSeacrhLineTop.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(764, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 44);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AcademyAdminPanel.Properties.Resources.brush1;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 44);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelSeacrhLineTop);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1030, 43);
            this.panelHeader.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.cmbClassroom,
            this.cmbTeacher,
            this.cmbMentor,
            this.Column6,
            this.cmbProgram,
            this.dgvRemove});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 555);
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
            this.Column1.DataPropertyName = "any";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Student Name";
            // 
            // cmbClassroom
            // 
            this.cmbClassroom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmbClassroom.DataPropertyName = "any";
            this.cmbClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClassroom.HeaderText = "Classroom";
            this.cmbClassroom.Name = "cmbClassroom";
            this.cmbClassroom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmbClassroom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbClassroom.ToolTipText = "Group Classroom";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmbTeacher.DataPropertyName = "any";
            this.cmbTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTeacher.HeaderText = "Teacher";
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmbTeacher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbTeacher.ToolTipText = "Group teacher";
            // 
            // cmbMentor
            // 
            this.cmbMentor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmbMentor.DataPropertyName = "any";
            this.cmbMentor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMentor.HeaderText = "Mentor";
            this.cmbMentor.Name = "cmbMentor";
            this.cmbMentor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmbMentor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbMentor.ToolTipText = "Group mentor";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "onlyNumber";
            this.Column6.HeaderText = "Capacity";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.ToolTipText = "Group catacity";
            // 
            // cmbProgram
            // 
            this.cmbProgram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmbProgram.DataPropertyName = "any";
            this.cmbProgram.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cmbProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProgram.HeaderText = "Program";
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cmbProgram.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbProgram.ToolTipText = "Group program";
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
            // panelFormBody
            // 
            this.panelFormBody.Controls.Add(this.panelBottom);
            this.panelFormBody.Controls.Add(this.PanelGrid);
            this.panelFormBody.Controls.Add(this.panelHeader);
            this.panelFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormBody.Location = new System.Drawing.Point(0, 0);
            this.panelFormBody.Name = "panelFormBody";
            this.panelFormBody.Size = new System.Drawing.Size(1030, 598);
            this.panelFormBody.TabIndex = 12;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lblSelectedGroup);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.lblBiggerGroup);
            this.panelBottom.Controls.Add(this.label7);
            this.panelBottom.Controls.Add(this.lblWithoutMentor);
            this.panelBottom.Controls.Add(this.label12);
            this.panelBottom.Controls.Add(this.lblWithoutTeacher);
            this.panelBottom.Controls.Add(this.label10);
            this.panelBottom.Controls.Add(this.lblGroupCount);
            this.panelBottom.Controls.Add(this.label8);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 562);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1030, 36);
            this.panelBottom.TabIndex = 13;
            // 
            // lblSelectedGroup
            // 
            this.lblSelectedGroup.AutoSize = true;
            this.lblSelectedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblSelectedGroup.Location = new System.Drawing.Point(846, 12);
            this.lblSelectedGroup.Name = "lblSelectedGroup";
            this.lblSelectedGroup.Size = new System.Drawing.Size(33, 15);
            this.lblSelectedGroup.TabIndex = 26;
            this.lblSelectedGroup.Text = "Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(727, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Selected group:";
            // 
            // lblBiggerGroup
            // 
            this.lblBiggerGroup.AutoSize = true;
            this.lblBiggerGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiggerGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblBiggerGroup.Location = new System.Drawing.Point(272, 11);
            this.lblBiggerGroup.Name = "lblBiggerGroup";
            this.lblBiggerGroup.Size = new System.Drawing.Size(39, 15);
            this.lblBiggerGroup.TabIndex = 24;
            this.lblBiggerGroup.Text = "none";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(166, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Bigger group";
            // 
            // lblWithoutMentor
            // 
            this.lblWithoutMentor.AutoSize = true;
            this.lblWithoutMentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithoutMentor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblWithoutMentor.Location = new System.Drawing.Point(685, 11);
            this.lblWithoutMentor.Name = "lblWithoutMentor";
            this.lblWithoutMentor.Size = new System.Drawing.Size(15, 15);
            this.lblWithoutMentor.TabIndex = 22;
            this.lblWithoutMentor.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(568, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Without mentor:";
            // 
            // lblWithoutTeacher
            // 
            this.lblWithoutTeacher.AutoSize = true;
            this.lblWithoutTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithoutTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblWithoutTeacher.Location = new System.Drawing.Point(529, 11);
            this.lblWithoutTeacher.Name = "lblWithoutTeacher";
            this.lblWithoutTeacher.Size = new System.Drawing.Size(15, 15);
            this.lblWithoutTeacher.TabIndex = 19;
            this.lblWithoutTeacher.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(406, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Without teacher";
            // 
            // lblGroupCount
            // 
            this.lblGroupCount.AutoSize = true;
            this.lblGroupCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblGroupCount.Location = new System.Drawing.Point(131, 11);
            this.lblGroupCount.Name = "lblGroupCount";
            this.lblGroupCount.Size = new System.Drawing.Size(15, 15);
            this.lblGroupCount.TabIndex = 17;
            this.lblGroupCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(23, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Group count:";
            // 
            // PanelGrid
            // 
            this.PanelGrid.Controls.Add(this.dataGridView1);
            this.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGrid.Location = new System.Drawing.Point(0, 43);
            this.PanelGrid.Name = "PanelGrid";
            this.PanelGrid.Size = new System.Drawing.Size(1030, 555);
            this.PanelGrid.TabIndex = 7;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 598);
            this.Controls.Add(this.panelFormBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.PanelGroupBy.ResumeLayout(false);
            this.PanelGroupBy.PerformLayout();
            this.panelAddbutton.ResumeLayout(false);
            this.panelSeacrhLineTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelSearchTextBox.ResumeLayout(false);
            this.PanelInnerSearchTextBox.ResumeLayout(false);
            this.PanelInnerSearchTextBox.PerformLayout();
            this.PanelSeacrhButton.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFormBody.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.PanelGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelGroupBy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelAddbutton;
        private System.Windows.Forms.Panel panelSeacrhLineTop;
        private System.Windows.Forms.Panel PanelSearchTextBox;
        private System.Windows.Forms.Panel PanelInnerSearchTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelSeacrhButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelFormBody;
        private System.Windows.Forms.Panel PanelGrid;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblBiggerGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWithoutMentor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblWithoutTeacher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGroupCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbClassroom;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbTeacher;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbMentor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbProgram;
        private System.Windows.Forms.DataGridViewButtonColumn dgvRemove;
        private System.Windows.Forms.Label lblSelectedGroup;
        private System.Windows.Forms.Label label1;
    }
}