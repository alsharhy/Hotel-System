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
    public partial class UserControlResevation : UserControl
    {
        DbConnector db;
        private string RID = "", No;
        public UserControlResevation()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxRoomNumber.SelectedIndex = 0;
            textBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlResevation.SelectedTab = tabPageAddResevation;

        }

        private void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxrRoomNumber1.SelectedIndex = 0;
            textBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";

        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UserControlResevation_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex=0;
            comboBoxRoomNumber.SelectedIndex=0;
            comboBoxType1.SelectedIndex = 0;
            comboBoxrRoomNumber1.SelectedIndex=0;
        }

        private void tabPageAddResevation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool chick;
            if (comboBoxType.SelectedIndex == 0 || comboBoxRoomNumber.SelectedIndex == 0 || textBoxClientID.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill out all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                chick = db.AddReservation(comboBoxType.SelectedItem.ToString(), comboBoxRoomNumber.SelectedItem.ToString(), textBoxClientID.Text, dateTimePickerIn.Text, dateTimePickerOut.Text );
                db.UpdateReservationRoom(comboBoxRoomNumber.SelectedItem.ToString(), "No");
            }
        }

        private void tabPageSearchResevation_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Reservation_Table", dataGridViewResevation);
        }

        private void tabPageSearchResevation_Leave(object sender, EventArgs e)
        {
            textBoxClientID.Clear();
        }

        private void textBoxSearchphoneNo_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Reservation_Table WHERE Reservation_Client_ID LIKE '%" +textBoxClientID.Text + "%' ", dataGridViewResevation);
        }

        private void dataGridViewResevation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewResevation.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                No = row.Cells[2].Value.ToString();
                textBoxClientID1.Text = row.Cells[3].Value.ToString();
                dateTimePickerIn.Text = row.Cells[4].Value.ToString();
                dateTimePickerOut1.Text = row.Cells[5].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool chick;
            if (RID != "")
            {
                
                if (comboBoxType1.SelectedIndex == 0 || comboBoxrRoomNumber1.SelectedIndex == 0 || textBoxClientID1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Please fill out all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    chick = db.UpdateReservation(RID , comboBoxType1.SelectedItem.ToString(), comboBoxrRoomNumber1.SelectedItem.ToString(), textBoxClientID1.Text, dateTimePickerIn1.Text, dateTimePickerOut1.Text);
                    db.UpdateReservationRoom(No, "Yes");
                    db.UpdateReservationRoom(comboBoxrRoomNumber1.SelectedItem.ToString(), "No");
                    if (chick)
                    {
                        Clear1();
                    }
                }

            }else
            {
                MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != "")
            {

                if (comboBoxType1.SelectedIndex == 0 || textBoxClientID1.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to Cancel this Reservation", "Reservation Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        check = db.DeleteReservation(RID);
                        if (check)
                            Clear1();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabPageUpdateandDelateResevation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '"+comboBoxType1.SelectedItem.ToString()+"' AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxrRoomNumber1);
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + comboBoxType.SelectedItem.ToString() + "' AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxRoomNumber);
        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
