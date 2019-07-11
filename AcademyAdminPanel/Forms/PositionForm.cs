using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademyAdminPanel.Model;

namespace AcademyAdminPanel.Forms
{
    public partial class PositionForm : Form
    {
        bool formLoaded = false;
        public PositionForm()
        {
            InitializeComponent();
            refreshForm();
            formLoaded = true;
        }

        // Refresh form
        public void refreshForm()
        {
            using (var db = new AcademyDB())
            {
                fillGrid(db.Position.ToList());
            }
        }

        // Fill grid Method
        public void fillGrid(List<Position> list)
        {
            dataGridView1.Rows.Clear();
            getStatistic();
            using (var db = new AcademyDB())
            {
                foreach (Position pos in list)
                {
                    if (pos.Deleted == false)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = pos.id;
                        row.Cells[1].Value = pos.Name;

                        // if no one in this position than set orange color
                        Employee emp = db.Employee.FirstOrDefault(em => em.PositionID == pos.id);
                        if (emp == null)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(241, 196, 15);
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                        }

                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }
        // Add position
        private void button1_Click(object sender, EventArgs e)
        {
            string pzName = textBox1.Text.ToLower();
            using (var db = new AcademyDB())
            {
                Position exitPz = db.Position.FirstOrDefault(c => c.Deleted == false && c.Name.ToLower() == pzName);

                if (isValid())
                {
                    if (exitPz == null)
                    {
                        Position newPosition = new Position()
                        {
                            Name = textBox1.Text
                        };

                        db.Position.Add(newPosition);

                        if (db.SaveChanges() == 0)
                        {
                            MessageBox.Show("Error: Position did not added");
                        }
                        else
                        {
                            ClearInputs();
                            refreshForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("This position is alredy exists!");
                    }
                }
            }
        }
        // update Position from Grid
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (formLoaded && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                int posID = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                using (var db = new AcademyDB())
                {
                    if (CheckRow(e.RowIndex)) // checking cells validation
                    {
                        Position pos = db.Position.FirstOrDefault(c => c.id == posID);

                        pos.Name = row.Cells[1].Value.ToString();

                        if (db.SaveChanges() != 0)
                        {
                            fillGrid(db.Position.ToList());
                            dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(224, 255, 224);
                        }
                        else
                        {
                            MessageBox.Show("Warning: Program did not updated!");
                        }
                    }
                }
            }
        }

        // Checking rows validation
        public bool CheckRow(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            int cellsCount = 0;
            int valid = 0;
            for (int i = 1; i < row.Cells.Count; i++)
            {
                if (row.Cells[i] is DataGridViewTextBoxCell)
                {
                    if (row.Cells[i].Value is null)
                    {
                        cellsCount++;
                        MessageBox.Show(row.Cells[i].OwningColumn.HeaderText + " is empty!");
                        row.Cells[i].Style.BackColor = Color.FromArgb(255, 118, 117);
                    }
                    else
                    {
                        cellsCount++;
                        if (Validation.CheckCell(row.Cells[i].OwningColumn.HeaderText, row.Cells[i].Value.ToString(), row.Cells[i].OwningColumn.DataPropertyName) == "ok")
                        {
                            valid++;
                            row.Cells[i].Style.BackColor = Color.White;
                        }
                        else
                        {
                            MessageBox.Show(Validation.CheckCell(row.Cells[i].OwningColumn.HeaderText, row.Cells[i].Value.ToString(), row.Cells[i].OwningColumn.DataPropertyName));
                            row.Cells[i].Style.BackColor = Color.FromArgb(255, 118, 117);
                        }
                    }
                }
            }
            if (valid == cellsCount) { return true; }
            else return false;
        }

        // Ipnut validation
        public bool isValid()
        {
            int inputCount = 0;
            int valid = 0;
            foreach (Control con in panelAdd.Controls)
            {
                if (con is TextBox)
                {
                    inputCount++;
                    if (Validation.CheckCell(con.AccessibleName, con.Text, con.AccessibleDescription) == "ok")
                    {
                        valid++;
                    }
                    else
                    {
                        ToolTip toolTip = new ToolTip();
                        toolTip.IsBalloon = true;
                        toolTip.Show(Validation.CheckCell(con.AccessibleName, con.Text, con.AccessibleDescription), con, 50, -50, 2000);
                    }
                }
            }
            if (valid == inputCount)
            {
                return true;
            }
            else return false;
        }

        // Clear inputs
        public void ClearInputs()
        {
            foreach (Control con in panelAdd.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = string.Empty;
                }
            }
        }
        // Search position
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox4.Text;
            using (var db = new AcademyDB())
            {
                List<Position> posList = db.Position.Where(c => c.Name.Contains(searchText)).ToList();
                fillGrid(posList);
            }
        }
        // Delete button
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            // if column is Delete button column
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DialogResult result = MessageBox.Show(row.Cells[1].Value.ToString(), "Are you sure to delete?", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    using (var db = new AcademyDB())
                    {
                        int posID = (int)row.Cells[0].Value;
                        Position position = db.Position.FirstOrDefault(c => c.id == posID);

                        int empCount = db.Employee.Where(em => em.PositionID == posID && em.Deleted == false).Count();
                        if (empCount > 0)
                        {
                            DialogResult res = MessageBox.Show(" We have " + empCount+ " employers working as " + position.Name + " if you will delete this position thouse employers will be invisible in list", "Are you sure to delete?", MessageBoxButtons.OKCancel);

                            if (res == DialogResult.OK)
                            {
                                position.Deleted = true;
                            }
                        }
                        else
                        {
                            position.Deleted = true;
                        }

                        if (db.SaveChanges() != 0)
                        {
                            refreshForm();
                        }
                        else
                        {
                            MessageBox.Show("Position did not deleted");
                        }
                    }
                }
            }
        }

        // get statistic
        public void getStatistic()
        {
            using (var db = new AcademyDB())
            {
                int freePos = 0;
                int posCount = 0;

                foreach (Position pos in db.Position.Where(pr => pr.Deleted == false).ToList())
                {
                    Employee emp = db.Employee.FirstOrDefault(em => em.PositionID == pos.id && em.Deleted == false);

                    if (emp == null)
                    {
                        freePos++;
                    }
                    posCount++;
                }

                lblFreePosition.Text = freePos.ToString();
                lblPosCount.Text = posCount.ToString();
            }
        }

        //Selected position statistic
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != dataGridView1.Rows.Count - 1) {
                {
                    int posID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    using (var db = new AcademyDB())
                    {
                        string posName = db.Position.FirstOrDefault(p => p.id == posID && p.Deleted == false).Name;
                        int empCount = db.Employee.Where(emp => emp.PositionID == posID && emp.Deleted == false).Count();

                        lblSelectedPosition.Text = posName + " ( Employers: " + empCount + " )";
                    }
                }
            }
        }
        //Draw icons to datagridview buttons
        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.del16.Width;
                var h = Properties.Resources.del16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.del16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
