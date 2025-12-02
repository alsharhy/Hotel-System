using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;

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
            textBoxLastName1.Clear();
            textBoxPhoneNo1.Clear();
            textBoxAddress1.Clear();
            ID = "";
            //tabControlClient.SelectedTab = tabPageAddClient;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxFirstName.Text.Trim() == String.Empty || textBoxLastName.Text.Trim() == string.Empty || textBoxPhoneNo.Text.Trim() == string.Empty
                || textBoxAddress.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check= db.AddClient(textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(), textBoxPhoneNo.Text.Trim(), textBoxAddress.Text.Trim());
                if (check)
                    Clear();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxFirstName1.Text.Trim() == String.Empty || textBoxLastName1.Text.Trim() == string.Empty || textBoxPhoneNo1.Text.Trim() == string.Empty
                 || textBoxAddress1.Text.Trim() == string.Empty) { 
                    MessageBox.Show("Please fill out all field", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check = db.AddClient(textBoxFirstName1.Text.Trim(), textBoxLastName1.Text.Trim(), textBoxPhoneNo1.Text.Trim(), textBoxAddress1.Text.Trim());
                if (check)
                    Clear1();
            }
        }else
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
            db.DisplayAndSearch("SELECT * FROM Client_Phone LIKE '%'",textBoxSearchphoneNo.Text + "'%'", dataGridViewClient);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            bool check;
            if (ID != "")
            {
                if (textBoxFirstName1.Text.Trim() == String.Empty || textBoxLastName1.Text.Trim() == string.Empty || textBoxPhoneNo1.Text.Trim() == string.Empty
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


        public void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNo.Clear();
            textBoxAddress.Clear();
            //tabControlClient.SelectedTab = tabPageAddClient; 
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

            if (textBoxFirstName.Text.Trim() == string.Empty ||
                textBoxLastName.Text.Trim() == string.Empty ||
                textBoxPhoneNo.Text.Trim() == string.Empty ||
                textBoxAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.",
                                "Require all fields",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                check = db.AddClient(textBoxFirstName.Text.Trim(),
                                   textBoxLastName.Text.Trim(),
                                   textBoxPhoneNo.Text.Trim(),
                                   textBoxAddress.Text.Trim());

                if (check)
                    Clear();
            }
        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Client_Table", dataGridViewClient);
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchphoneNo.Clear();
            //textBoxSearchPhoneNo.Clear();

        }

        private void textBoxSearchphoneNo_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Client_Table WHERE Client_Phone LIKE '%" + textBoxSearchphoneNo.Text + "%'", dataGridViewClient);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {

                if (textBoxFirstName1.Text.Trim() == string.Empty ||
                textBoxLastname1.Text.Trim() == string.Empty ||
                textBoxPhoneNo1.Text.Trim() == string.Empty ||
                textBoxAddress1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all fields.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.UpdateClient(ID, textBoxFirstName1.Text.Trim(), textBoxLastname1.Text.Trim(), textBoxPhoneNo1.Text.Trim(), textBoxAddress1.Text.Trim());

                    if (check)
                    {
                        Clear1();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please first select row from table.", "Selection of row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }







        private void tabPageUdateandDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

    }














}
