using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VacationGetaways
{
    public partial class frmWelcome : Form
    {
        
        public frmWelcome()
        {
            InitializeComponent();
            //Get the Welcome Screen to show up in the center of the screen
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            // Display Login Form
            LoginPage LoginPage = new LoginPage();
            LoginPage.StartPosition = FormStartPosition.CenterScreen;
            LoginPage.ShowDialog();
            //If the user sucessfully logged in on the Login Form 
            //Then allow access to the View Past Trips AND Logout Buttons
            
            if (Globals.aUserIsLoggedIn == true)
            {
                btnPastTrips.Enabled = true;
                btnLogout.Enabled = true;
                btnCreateNewAccount.Enabled = false;
                btnLogin.Enabled = false;
                btnCulture.Enabled = true;
                btnCelebration.Enabled = true;
                btnRelaxing.Enabled = true;
                lblWelcome.Text = String.Format("Welcome Back {0}", Globals.loggedInUsersEmail);

            }
            else
            {
                btnPastTrips.Enabled = false;
                btnLogout.Enabled = false;
            }
        }

        private void picGlobe_Click(object sender, EventArgs e)
        {

        }

        private void btnCulture_Click(object sender, EventArgs e)
        {
            // Display Culture Form
            frmCulture Culture = new frmCulture();
            Culture.StartPosition = FormStartPosition.CenterScreen;
            Culture.ShowDialog();
            // this.Hide();
        }

        private void btnRelaxing_Click(object sender, EventArgs e)
        {
            // Display Relaxing Form
            frmRelax Relax = new frmRelax();
            Relax.StartPosition = FormStartPosition.CenterScreen;
            Relax.ShowDialog();
            // this.Hide();
        }

        private void btnCelebration_Click(object sender, EventArgs e)
        {
            // Display Celebrate Form
            frmCelebrate Celebrate = new frmCelebrate();
            Celebrate.StartPosition = FormStartPosition.CenterScreen;
            Celebrate.ShowDialog();
            //this.Hide();
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            frmCreateNew createNew = new frmCreateNew();
            createNew.StartPosition = FormStartPosition.CenterScreen;
            createNew.ShowDialog();
            this.Focus();
        }

        private void btnPastTrips_Click(object sender, EventArgs e)
        {
            frmViewPastTrips pastTrips = new frmViewPastTrips();
            pastTrips.StartPosition = FormStartPosition.CenterScreen;
            pastTrips.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnCreateNewAccount.Enabled = true;
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnPastTrips.Enabled = false;
            btnCulture.Enabled = false;
            btnCelebration.Enabled = false;
            btnRelaxing.Enabled = false;
            lblWelcome.Text = ("Welcome");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
