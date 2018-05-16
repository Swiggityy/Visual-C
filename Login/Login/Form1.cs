using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // declare variables and constants
            const string VALID_MANAGER = "MGR";
            const string VALID_PASSWORD = "letmein";
            string userName, password;

            // input data from user

            userName = textBoxUsername.Text;
            password = textBoxPassword.Text;

            // check username
            /*if (userName == VALID_MANAGER)
                if (password == VALID_PASSWORD)
                    lblWelcome.Text = "Welcome";
                else
                    lblWelcome.Text = "Password is Incorrect";
            else
                lblWelcome.Text = "Login Failed"; */

            if (userName == VALID_MANAGER && password == VALID_PASSWORD)
                    lblWelcome.Text = "Welcome";
            else
                lblWelcome.Text = "Login Failed";

        }
    }
}
