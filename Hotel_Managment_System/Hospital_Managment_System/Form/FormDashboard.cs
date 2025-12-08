using System;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }


        //المؤشر الجانبي للتنقل بين الاقسام الفيديو 2 
        private void MovePanel(Control btn)
        {
            panel6.Top = btn.Top;
            panel6.Height = btn.Height;
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void FormDashboard_Load(object sender, EventArgs e)
        {

            timer1.Start();
            labelUsername.Text = Username;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDataTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }



        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlDashboard1.User();
            userControlDashboard1.Client();
            userControlDashboard1.Room();
            userControlDashboard1.BringToFront();


        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControlClient1.Clear();
            userControlClient1.BringToFront();
        }
         
        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            userControlRoom1.Clear();
            userControlRoom1.BringToFront();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlResevation1.Clear();
            userControlResevation1.BringToFront();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSetting);
            userControlSetting1.Clear();
            userControlSetting1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show("Are You Want To Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }

        }

        private void userControlResevation1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
