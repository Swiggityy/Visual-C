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
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Display second form
            LoginPage LoginPage = new LoginPage();
            LoginPage.Show();
           // this.Hide();
        }

        private void picGlobe_Click(object sender, EventArgs e)
        {

        }

        private void btnCulture_Click(object sender, EventArgs e)
        {
            // Display Culture Form
            frmCulture Culture = new frmCulture();
            Culture.Show();
            // this.Hide();
        }

        private void btnRelaxing_Click(object sender, EventArgs e)
        {
            // Display Relaxing Form
            frmRelax Relax = new frmRelax();
            Relax.Show();
            // this.Hide();
        }

        private void btnCelebration_Click(object sender, EventArgs e)
        {
            // Display Celebrate Form
            frmCelebrate Celebrate = new frmCelebrate();
            Celebrate.Show();
            // this.Hide();
        }

        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            frmCreateNew createNew = new frmCreateNew();
            createNew.Show();
        }

        private void btnPastTrips_Click(object sender, EventArgs e)
        {
            frmViewPastTrips pastTrips = new frmViewPastTrips();
            pastTrips.Show();
        }
    }
}
