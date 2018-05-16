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
using System.Text.RegularExpressions;

namespace VacationGetaways
{
    public partial class frmCreateNew : Form
    {
        
        public frmCreateNew()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCreateNew_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Declare Variables and Constants
            string firstName, lastName, password, eMail;
            const string USERS_FILE = "usersFile.txt";
            bool foundMatchForEMail;

            if (rdYes.Checked == true && txtFirstName.Text != "" && txtLastName.Text != "" && txtPassword.Text != "" && txtEmail.Text != "")
                {
             
                FileStream usersOutFile2 = new FileStream(USERS_FILE, FileMode.Append, FileAccess.Write);
                StreamWriter usersFileWriter = new StreamWriter(usersOutFile2);

                // Input from user
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                eMail = txtEmail.Text;
                password = txtPassword.Text;

                // Save to Users File
                usersFileWriter.WriteLine(firstName);
                usersFileWriter.WriteLine(lastName);
                usersFileWriter.WriteLine(eMail);
                usersFileWriter.WriteLine(password);
                usersFileWriter.WriteLine("****Entry End****");

                // Close file
                usersFileWriter.Close();
                usersOutFile2.Close();

                // Clear textboxes for next user
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                rdYes.Checked = false;
                txtFirstName.Focus();

                lblError1.Text = "Congratualtions! You've successfully created an account!";
            }
            else
                lblError1.Text = "Please ensure all fields have valid entries";

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
          
        }
        
        //This Function will check to see if email already exsists in the file
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Declare Variables and Constants
            string firstName, lastName, eMail, password, endOfEntryMarker;
            string firstNameFromFile, lastNameFromFile, eMailFromFile, passwordFromFile;
            const string USERS_FILE = "usersFile.txt";
            bool foundMatchForEMail;

            //Create the Users File and prepare for use 
            FileStream usersOutFile = new FileStream(USERS_FILE, FileMode.Open, FileAccess.Read);
            StreamReader usersFileReader = new StreamReader(usersOutFile);

            // Input from user
            eMail = txtEmail.Text;

            //Read from Users File to find match for entereed EMail & Password          
            foundMatchForEMail = false;
            firstNameFromFile = usersFileReader.ReadLine();
            
            while (!usersFileReader.EndOfStream && foundMatchForEMail== false)
            {
                lastNameFromFile = usersFileReader.ReadLine();
                eMailFromFile = usersFileReader.ReadLine();
                passwordFromFile = usersFileReader.ReadLine();
                endOfEntryMarker = usersFileReader.ReadLine();

                if (string.Compare(eMailFromFile, eMail) == 0)
                {
                    foundMatchForEMail = true;
                    lblError1.Text = string.Format("The email: {0} already has an existing account on file.",eMail);
                    txtEmail.BackColor = Color.Red;
                    txtEmail.Text = "";
                }
                else
                {
                    foundMatchForEMail = false;
                    lblError1.Text = string.Format("This email: {0} is available for use.", eMail);
                    txtEmail.BackColor = Color.White;
                }

                firstNameFromFile = usersFileReader.ReadLine();
            }
            // Close file
            usersFileReader.Close();
            usersOutFile.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rdYes_CheckedChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtPassword.Text != "" && txtEmail.Text != "" && rdYes.Checked == true)
            {
                btnCreate.Enabled = true;
            }
            else
                btnCreate.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblError1.Text = "Are you sure you want to go back";
            WarningOnCancel WarningOnCancel = new WarningOnCancel();
            WarningOnCancel.StartPosition = FormStartPosition.CenterScreen;
            WarningOnCancel.ShowDialog();

            if (WarningOnCancel.backToNewAccountSelected == true)
                lblError1.Text = "User Selected to Continue from Back";
            else
                Dispose();
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[a-z,A-Z]{1,10}((-|.)\w+)*@\w+.\w{3}$"))
            {
                MessageBox.Show("Not valid email.");
                txtEmail.Text = "";
            }
        }
    }
}
// Tim, I need help on the New Accounts frm. I tried to install a double account stop measure, but can't seem to get it to work. Please take a look.