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
using System.Xml.Serialization;

namespace VacationGetaways
{
    public partial class BookTrip2P : Form
    {
        public BookTrip2P()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           

            
            lblBackBtnMessage.Text = "Are you sure you want to go back";
            WarningOnBack WarningOnBack = new WarningOnBack();
            WarningOnBack.StartPosition = FormStartPosition.CenterScreen;
            WarningOnBack.ShowDialog();

            if (WarningOnBack.backToBookingSelected == true)
                lblBackBtnMessage.Text = "User Selected to Continue from Back";
            else
                Dispose();
        }

        private void BookTrip2P_Load(object sender, EventArgs e)
        {
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            string bookingRecordStart, email, dateOfTravel, numOfTravelers, firstName2, middleName2, lastName2, contactNumber2, gender2, birthDate2, firstName, middleName, lastName, contactNumber, gender;
            string cardHolderName, debitCreditCardNumber, expirationMonth, expirationYear, securityCode, birthDate, creditCardType, bookingRecordEnd;
            const string FILENAME = "ConfirmationInfo.txt";
            const string TWO_BOOKING_RECORD_START = "**Two Person Booking Record Start**";
            const string TWO_BOOKING_RECORD_END = "**Two Person Booking Record End**";

            // Declare our FileStream and StreamWriter
            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            // Input from user
                dateOfTravel = dtpDateOfTravel.Text;
                numOfTravelers = "2";

                firstName = txtFirstName.Text;
                middleName = txtMiddleName.Text;
                lastName = txtLastName.Text;
                contactNumber = txtContactNumber.Text;
                if (rbMale.Checked == true)
                {
                    gender = ("M");
                }
                else
                    gender = ("F");
                birthDate = dtp1.Text;

               //Set the email from the GlobalEmail variable assigned in the Login form
               //Just in case it got here without the email set, then set it to NoEmailEntered
                email = Globals.loggedInUsersEmail;
                if (email == "")
                  email = "NoEmailEntered";

                firstName2 = txtFirstName2.Text;
                middleName2 = txtMiddleName2.Text;
                lastName2 = txtLastName2.Text;
                contactNumber2 = txtContactNumber2.Text;

                if (rdbMale2.Checked == true)
                {
                    gender2 = ("M");
                }
                else
                    gender2 = ("F");
                birthDate2 = dtp2.Text;

                cardHolderName = txtCardHolderName.Text;
                debitCreditCardNumber = txtDebitCreditCardNumber.Text;
                expirationMonth = txtExpirationMonth.Text;
                expirationYear = txtExpirationYear.Text;
                securityCode = txtSecurityCode.Text;
                creditCardType = txtCreditCardType.Text;
            
            // Save to temp file
                writer.WriteLine(TWO_BOOKING_RECORD_START);
                writer.WriteLine(email);

                writer.WriteLine(dateOfTravel);
                writer.WriteLine(numOfTravelers);

                writer.WriteLine(firstName);
                writer.WriteLine(middleName);
                writer.WriteLine(lastName);
                writer.WriteLine(contactNumber);
                writer.WriteLine(gender);
                writer.WriteLine(birthDate);

                writer.WriteLine(firstName2);
                writer.WriteLine(middleName2);
                writer.WriteLine(lastName2);
                writer.WriteLine(contactNumber2);
                writer.WriteLine(gender2);
                writer.WriteLine(birthDate2);

                writer.WriteLine(cardHolderName);
                writer.WriteLine(debitCreditCardNumber);
                writer.WriteLine(expirationMonth);
                writer.WriteLine(expirationYear);
                writer.WriteLine(securityCode);
                writer.WriteLine(creditCardType);
                writer.WriteLine(TWO_BOOKING_RECORD_END);

            // Close file
            // temp
            writer.Close();
                outFile.Close();
                if (txtFirstName2.Text != "" && txtLastName2.Text != "" && txtContactNumber2.Text != "" && (rdbMale2.Checked == true || rdbFemale2.Checked == true) && dtp2.Checked == true && txtFirstName.Text != "" && txtLastName.Text != "" && txtContactNumber.Text != "" && (rbMale.Checked == true || rbFemale.Checked == true) && dtp1.Checked == true && txtCardHolderName.Text != "" && txtDebitCreditCardNumber.Text != "" && txtExpirationMonth.Text != "" && txtExpirationYear.Text != "" && txtSecurityCode.Text != "" && txtCreditCardType.Text != "")
                { 
                    btnSubmit.Enabled = true;
                    lblError2.Visible = false;
                }
                else
                {
                    lblError2.Visible = true;
               

                }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Display second form
            Confirmation2 confirmation2 = new Confirmation2();
            confirmation2.StartPosition = FormStartPosition.CenterScreen;
            confirmation2.ShowDialog();
            this.Close();
        }

        private void txtCreditCardType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtContactNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtFirstName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMiddleName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtLastName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtContactNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCardHolderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsLetter(ch) && ch != 8 && ch != 0x20)
            {
                e.Handled = true;
            }
        }

        private void txtDebitCreditCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtExpirationMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtExpirationYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSecurityCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDebitCreditCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDebitCreditCardNumber_Leave(object sender, EventArgs e)
        {
            if (txtDebitCreditCardNumber.TextLength != 16)
            {
                MessageBox.Show("Please enter a valid Credit/Debit card number");
                txtDebitCreditCardNumber.Text = "";
            }
        }
    }
}

