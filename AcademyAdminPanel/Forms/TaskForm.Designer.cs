namespace AcademyAdminPanel.Forms
{
    partial class TaskForm
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
            this.panelHeaderTop = new System.Windows.Forms.Panel();
            this.panelAddButton = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.PanelGroupBy = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelSortButton = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelSearchTextBox = new System.Windows.Forms.Panel();
            this.PanelInnerSearchTextBox = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelSeacrhButton = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSeacrhLineTop = new System.Windows.Forms.Panel();
            this.PanelSearchLineBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCombobox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelFormBody = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelHeaderTop.SuspendLayout();
            this.panelAddButton.SuspendLayout();
            this.PanelGroupBy.SuspendLayout();
            this.panelSortButton.SuspendLayout();
            this.PanelSearchTextBox.SuspendLayout();
            this.PanelInnerSearchTextBox.SuspendLayout();
            this.PanelSeacrhButton.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSeacrhLineTop.SuspendLayout();
            this.PanelSearchLineBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFormBody.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeaderTop
            // 
            this.panelHeaderTop.Controls.Add(this.panelAddButton);
            this.panelHeaderTop.Controls.Add(this.PanelGroupBy);
            this.panelHeaderTop.Controls.Add(this.panelSortButton);
            this.panelHeaderTop.Controls.Add(this.PanelSearchTextBox);
            this.panelHeaderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderTop.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderTop.Name = "panelHeaderTop";
            this.panelHeaderTop.Size = new System.Drawing.Size(1012, 41);
            this.panelHeaderTop.TabIndex = 0;
            // 
            // panelAddButton
            // 
            this.panelAddButton.Controls.Add(this.button3);
            this.panelAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddButton.Location = new System.Drawing.Point(796, 0);
            this.panelAddButton.Name = "panelAddButton";
            this.panelAddButton.Size = new System.Drawing.Size(216, 41);
            this.panelAddButton.TabIndex = 1;
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
            this.button3.Size = new System.Drawing.Size(142, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PanelGroupBy
            // 
            this.PanelGroupBy.Controls.Add(this.button1);
            this.PanelGroupBy.Controls.Add(this.comboBox1);
            this.PanelGroupBy.Controls.Add(this.label6);
            this.PanelGroupBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelGroupBy.Location = new System.Drawing.Point(462, 0);
            this.PanelGroupBy.Name = "PanelGroupBy";
            this.PanelGroupBy.Size = new System.Drawing.Size(334, 41);
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(43, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Group";
            // 
            // panelSortButton
            // 
            this.panelSortButton.Controls.Add(this.button2);
            this.panelSortButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSortButton.Location = new System.Drawing.Point(399, 0);
            this.panelSortButton.Name = "panelSortButton";
            this.panelSortButton.Size = new System.Drawing.Size(63, 41);
            this.panelSortButton.TabIndex = 3;
            // 
            // button2
            // 
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
            this.PanelSearchTextBox.Size = new System.Drawing.Size(399, 41);
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
            this.PanelSeacrhButton.Size = new System.Drawing.Size(48, 41);
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
            // PanelSearchLineBottom
            // 
            this.PanelSearchLineBottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelSearchLineBottom.Controls.Add(this.label1);
            this.PanelSearchLineBottom.Controls.Add(this.dateTimePicker2);
            this.PanelSearchLineBottom.Controls.Add(this.dateTimePicker1);
            this.PanelSearchLineBottom.Controls.Add(this.label4);
            this.PanelSearchLineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSearchLineBottom.Location = new System.Drawing.Point(0, 45);
            this.PanelSearchLineBottom.Name = "PanelSearchLineBottom";
            this.PanelSearchLineBottom.Size = new System.Drawing.Size(1012, 50);
            this.PanelSearchLineBottom.TabIndex = 8;
            this.PanelSearchLineBottom.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(382, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(402, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 15);
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
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dedline between";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.dateTimePickerColumn,
            this.dgvCombobox,
            this.dgvOpen,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 456);
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
            this.Column1.ToolTipText = "Employee Name";
            // 
            // dateTimePickerColumn
            // 
            this.dateTimePickerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateTimePickerColumn.HeaderText = "Dedline";
            this.dateTimePickerColumn.Name = "dateTimePickerColumn";
            this.dateTimePickerColumn.ReadOnly = true;
            this.dateTimePickerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateTimePickerColumn.ToolTipText = "Task Dedline";
            // 
            // dgvCombobox
            // 
            this.dgvCombobox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCombobox.DataPropertyName = "any";
            this.dgvCombobox.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvCombobox.HeaderText = "Group";
            this.dgvCombobox.MaxDropDownItems = 5;
            this.dgvCombobox.Name = "dgvCombobox";
            this.dgvCombobox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCombobox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvCombobox.ToolTipText = "Task group";
            // 
            // dgvOpen
            // 
            this.dgvOpen.HeaderText = "Open task";
            this.dgvOpen.Name = "dgvOpen";
            this.dgvOpen.ReadOnly = true;
            this.dgvOpen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvOpen.ToolTipText = "Open task";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "dgvRemove";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Remove task";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.ToolTipText = "Delete employee";
            // 
            // panelFormBody
            // 
            this.panelFormBody.Controls.Add(this.panelGrid);
            this.panelFormBody.Controls.Add(this.panelHeader);
            this.panelFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormBody.Location = new System.Drawing.Point(0, 0);
            this.panelFormBody.Name = "panelFormBody";
            this.panelFormBody.Size = new System.Drawing.Size(1012, 551);
            this.panelFormBody.TabIndex = 11;
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
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 551);
            this.Controls.Add(this.panelFormBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "TaskFormcs";
            this.panelHeaderTop.ResumeLayout(false);
            this.panelAddButton.ResumeLayout(false);
            this.PanelGroupBy.ResumeLayout(false);
            this.PanelGroupBy.PerformLayout();
            this.panelSortButton.ResumeLayout(false);
            this.PanelSearchTextBox.ResumeLayout(false);
            this.PanelInnerSearchTextBox.ResumeLayout(false);
            this.PanelInnerSearchTextBox.PerformLayout();
            this.PanelSeacrhButton.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelSeacrhLineTop.ResumeLayout(false);
            this.PanelSearchLineBottom.ResumeLayout(false);
            this.PanelSearchLineBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFormBody.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderTop;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSeacrhLineTop;
        private System.Windows.Forms.Panel panelAddButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PanelGroupBy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelSortButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PanelSearchTextBox;
        private System.Windows.Forms.Panel PanelInnerSearchTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel PanelSeacrhButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel PanelSearchLineBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelFormBody;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimePickerColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvCombobox;
        private System.Windows.Forms.DataGridViewButtonColumn dgvOpen;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}