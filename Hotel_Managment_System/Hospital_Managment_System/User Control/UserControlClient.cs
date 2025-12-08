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
    public partial class UserControlClient : UserControl
    {
        DbConnector db;
        string ID = "";
        public UserControlClient()
        {
            InitializeComponent();
            db = new DbConnector();

        }
        public void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNo.Clear();
            textBoxAddress.Clear();
            ID = "";
            tabControlClient.SelectedTab = tabPageAddClient;

        }
        private void Clear1()
        {
            textBoxFirstName1.Clear();
            textBoxLastname1.Clear();
            textBoxPhoneNo1.Clear();
            textBoxAddress1.Clear();
            ID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxFirstName.Text.Trim() == String.Empty || textBoxLastName.Text.Trim() == string.Empty || textBoxPhoneNo.Text.Trim() == string.Empty
                || textBoxAddress.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddClient(textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(), textBoxPhoneNo.Text.Trim(), textBoxAddress.Text.Trim());
                if (check)
                    Clear();
            }

        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxFirstName1.Text.Trim() == String.Empty || textBoxLastname1.Text.Trim() == string.Empty || textBoxPhoneNo1.Text.Trim() == string.Empty
                 || textBoxAddress1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.UpdateClient(ID, textBoxFirstName1.Text.Trim(), textBoxLastname1.Text.Trim(), textBoxPhoneNo1.Text.Trim(), textBoxAddress1.Text.Trim());
                    if (check)
                        Clear1();
                }
            }
            else
            {
                MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonAdd_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Client_Table", dataGridViewClient);
        }

        private void tablSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchphoneNo.Clear();
        }

        private void textBoxSearchphoneNo_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Client_Table WHERE  Client_Phone LIKE '%" + textBoxSearchphoneNo.Text + "%'", dataGridViewClient);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            bool check;
            if (ID != "")
            {
                if (textBoxFirstName1.Text.Trim() == String.Empty || textBoxLastname1.Text.Trim() == string.Empty || textBoxPhoneNo1.Text.Trim() == string.Empty
                 || textBoxAddress1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to delete this Client", "Client Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        check = db.DeleteClient(ID);
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

        private void tabPageUpdateAndDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void tabPageAddClient_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // safe null handling and switch to Update/Delete tab for editing
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];

            ID = row.Cells[0].Value?.ToString() ?? string.Empty;
            textBoxFirstName1.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
            textBoxLastname1.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
            textBoxPhoneNo1.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
            textBoxAddress1.Text = row.Cells[4].Value?.ToString() ?? string.Empty;

            // navigate to update/delete tab so user sees populated fields
            tabControlClient.SelectedTab = tabPageUdateandDeleteClient;
        }
    }
}