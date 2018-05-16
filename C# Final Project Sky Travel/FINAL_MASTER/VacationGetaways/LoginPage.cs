using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VacationGetaways
{
    public partial class LoginPage : Form
    {
        public bool userIsLoggedIn { get; set; }
        public string userLoggedInEmail { get; set; }
        public string userLoggedInPassword { get; set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // Declare Variables and Constants
            string firstName, lastName, eMail, password;
            string firstNameFromFile, lastNameFromFile, emailFromFile, passwordFromFile, endOfEntry;
            bool foundMatchForEMail = false, foundMatchforPassword = false;
            const string USERS_FILE = "usersFile.txt";

            //Create the Users File and prepare for use 
            FileStream usersOutFile = new FileStream(USERS_FILE, FileMode.Open, FileAccess.Read);
            StreamReader usersFileReader = new StreamReader(usersOutFile);

           // Input from user
            eMail = txtEmail.Text;
            password = txtPass.Text;

           //Read from Users File to find match for entereed EMail & Password
           //First get the first name for loop check 
            firstNameFromFile = usersFileReader.ReadLine();
            
            //While not at the end of the file AND we have not found a match for entered email and password
            while (!usersFileReader.EndOfStream && (!foundMatchForEMail && !foundMatchforPassword))
            {
                //Read the rest of the variables
                lastNameFromFile = usersFileReader.ReadLine();
                emailFromFile = usersFileReader.ReadLine();
                passwordFromFile = usersFileReader.ReadLine();
                endOfEntry = usersFileReader.ReadLine();

                //If the entered email matches an email from the file
                if (string.Compare(emailFromFile, eMail) == 0)
                {
                    foundMatchForEMail = true;
                    //Now check if the password matches too 
                    if (string.Compare(passwordFromFile, password) == 0)
                    {
                        foundMatchforPassword = true;
                        lblError1.Text = String.Format("User: {0} Found in File", emailFromFile);
                    }

                }
                
                // Enter to continue
             //   DiagnoseFile DiagnoseFileHelp = new DiagnoseFile(lastNameFromFile, emailFromFile);
             //   DiagnoseFile.Show();
                firstNameFromFile = usersFileReader.ReadLine();
            }

            // Close files
            usersOutFile.Close();
            usersFileReader.Close();

            // Clear textboxes for next user
            txtEmail.Text = "";
            txtPass.Text = "";
            txtEmail.Focus();

            //If both email and password input for login match an entry in the file
            //Then set the Three variables to use in other parts of the program
            //Else, we don't have a match and we display the error message for user not found
            if (foundMatchForEMail && foundMatchforPassword)
            {
                Globals.aUserIsLoggedIn = true;
                Globals.loggedInUsersEmail= String.Copy(eMail);
                Globals.loggedInUsersPassword = password;
                Globals.currentSelectedNumOfPeople = 45;
               // userIsLoggedIn = true;
               // userLoggedInEmail = eMail;
               // userLoggedInPassword = password;
                MessageBox.Show("Congratulations, you've successfully logged in!");
                this.Close();
                
            }
            else
            {
                Globals.aUserIsLoggedIn = false;
                //  Globals.loggedInUsersName = "";
                //   Globals.loggedInUsersPassword = "";

                lblError1.Text = String.Format("Email or password not found.\r\nPlease reenter or Create New Account.");
                // Clear textboxes for next user
                txtEmail.Text = "";
                txtPass.Text = "";
                txtEmail.Focus();
            }
                
        
            
            // Enter to continue
            // EnterToContinue EnterToContinue = new EnterToContinue();
            //  EnterToContinue.Show();
            //this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Hides Login Page
            this.Close();
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
