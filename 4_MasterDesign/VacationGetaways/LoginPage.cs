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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email, password;
            const string FILENAME2 = "customersPerm.txt";

            // Permanent file
            FileStream outFile2 = new FileStream(FILENAME2, FileMode.Append, FileAccess.Write);
            StreamWriter writer2 = new StreamWriter(outFile2);

            // Input from user
            email = txtEmail.Text;
            password = txtPass.Text;

            // save to perm file
            writer2.WriteLine(email);
            writer2.WriteLine(password);

            // Close perm file
            writer2.Close();
            outFile2.Close();

            // Clear textboxes for next user
            txtEmail.Text = "";
            txtPass.Text = "";
            txtEmail.Focus();

            // Display second form
            frmWelcome secondForm = new frmWelcome();
            secondForm.Show();
            this.Hide();
        }
    }
}
