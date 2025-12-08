using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System.User_Control
{
    public partial class UserControlRoom : UserControl
    {
        DbConnector db;
        String NO = "", Free = "";

        public UserControlRoom()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {

        }




        public void Clear()
        {
            comboBoxType.SelectedIndex = -1;
            textBoxPhoneNo.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }


        private void Clear1()
        {
            comboBoxType1.SelectedIndex = -1;
            textBoxPhoneNo1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            NO = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (radioButtonYes.Checked)
            {
                Free = "Yes";
            }
            else if (radioButtonNo.Checked)
            {
                Free = "No";
            }


            bool check;

            if (comboBoxType.SelectedIndex == -1 || textBoxPhoneNo.Text.Trim() == string.Empty || Free == "")
                MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddRoom(comboBoxType.Text.Trim(), textBoxPhoneNo.Text.Trim(), Free);
                if (check)
                    Clear();
            }
        }


        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Room_Table", dataGridViewRoom);
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoomNumber.Clear();
        }

        private void textBoxSearchRoomNumber_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Room_Table WHERE Room_Number LIKE '%" + textBoxSearchRoomNumber.Text + "%'", dataGridViewRoom);
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewRoom.Rows.Count)
                return;

            DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];

            // local helper to find a cell by common column name/dataproperty/header keywords
            string GetCellValueByCandidates(params string[] candidates)
            {
                foreach (DataGridViewColumn col in dataGridViewRoom.Columns)
                {
                    var combined = (col.Name ?? "") + "|" + (col.DataPropertyName ?? "") + "|" + (col.HeaderText ?? "");
                    foreach (var c in candidates)
                    {
                        if (combined.IndexOf(c, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            var val = row.Cells[col.Index].Value;
                            if (val != null) return val.ToString();
                        }
                    }
                }

                // fallback: first non-null cell value
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell?.Value != null)
                        return cell.Value.ToString();

                return string.Empty;
            }

            // Try to map columns by likely names; falls back to first non-null cell
            NO = GetCellValueByCandidates("room_number", "roomno", "number", "no", "id");
            comboBoxType1.Text = GetCellValueByCandidates("type", "room_type", "type_name");
            textBoxPhoneNo1.Text = GetCellValueByCandidates("phone", "phone_no", "phone number", "contact");
            Free = GetCellValueByCandidates("free", "available", "status");

            // Normalize Free and set radio buttons
            if (string.Equals(Free, "yes", StringComparison.OrdinalIgnoreCase) || Free == "1")
            {
                radioButtonYes1.Checked = true;
                radioButtonNo1.Checked = false;
            }
            else if (string.Equals(Free, "no", StringComparison.OrdinalIgnoreCase) || Free == "0")
            {
                radioButtonNo1.Checked = true;
                radioButtonYes1.Checked = false;
            }
            else
            {
                radioButtonYes1.Checked = false;
                radioButtonNo1.Checked = false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                radioButtonNo1.Checked = false;
            else if (radioButtonNo1.Checked)
                radioButtonYes1.Checked = false;
            bool check;
            if (NO != "")
            {
                if (comboBoxType1.SelectedIndex == -1 || textBoxPhoneNo1.Text.Trim() == string.Empty || Free == "")

                    MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    check = db.UpdateRoom(NO, comboBoxType1.Text.Trim(), textBoxPhoneNo1.Text.Trim(), Free);
                    if (check)
                        Clear1();
                }
            }
            else
            {
                MessageBox.Show("Please select a room to update", "Select Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Yes";
            else if (radioButtonNo1.Checked)
                Free = "No";

            bool check;
            if (NO != "")
            {
                if (comboBoxType1.SelectedIndex == -1 || textBoxPhoneNo1.Text.Trim() == string.Empty || Free == "")
                    MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Are You Want To Delete This Room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        check = db.DeleteRoom(NO);
                        if (check)
                            Clear1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete", "Select Room", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}