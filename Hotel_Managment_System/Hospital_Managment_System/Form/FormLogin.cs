using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hospital_Managment_System
{
    public partial class FormLogin : Form
    {
        DbConnector db;
        public FormLogin()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        { 

        }

        //creat function close

        


        private void pictureBoxclose_Click(object sender, EventArgs e)

        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //Show Password
        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {

            // toolTip.SetToolTip((pictureBoxShow,"Show Password");

        }

        //Hide Password
        private void pictureBoxclose_MouseHover(object sender, EventArgs e)
        {

        }


        //Done
        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }


        //Done
        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool Check = db.IsValidNamePass(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill Out All Field.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                if (Check)
                {
                    FormDashboard fd = new FormDashboard();
                      fd.Username = textBoxUsername.Text;
                      textBoxUsername.Clear();
                      textBoxPassword.Clear();
                    
                    fd.Show();
                }
                else
                {
                    MessageBox.Show("Invalid UserNmae OR Password.", "UserNmae OR Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
