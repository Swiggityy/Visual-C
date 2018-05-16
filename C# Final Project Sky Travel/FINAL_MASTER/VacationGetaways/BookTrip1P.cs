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
    
    public partial class BookTrip1P : Form
    {
       

       

        public BookTrip1P()
        {
            InitializeComponent();
        }

        private void BookTrip1P_Load(object sender, EventArgs e)
        {
           
           
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPaymentContinue_Click(object sender, EventArgs e)
        {
            

           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Display second form
            Confirmation confirmation = new Confirmation();
            confirmation.StartPosition = FormStartPosition.CenterScreen;
            confirmation.ShowDialog();
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string email, dateOfTravel, numOfTravelers, firstName, middleName, lastName, contactNumber, gender, cardHolderName, debitCreditCardNumber;
            string expirationMonth, expirationYear, securityCode, birthDate, creditCardType, tripDate;
            const string FILENAME = "ConfirmationInfo.txt";
            const string ONE_BOOKING_RECORD_START = "**One Person Booking Record Start**";
            const string ONE_BOOKING_RECORD_END   = "**One Person Booking Record End**";

            // Declare our FileStream and StreamWriter
            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            //Set the email from the GlobalEmail variable assigned in the Login form
            //Just in case it got here without the email set, then set it to NoEmailEntered
            email = Globals.loggedInUsersEmail;
            if (email == "")
                email = "NoEmailEntered";

            // Input from user
            dateOfTravel = dtpDateOfTravel.Text;
            numOfTravelers = "1";
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
            cardHolderName = txtCardHolderName.Text;
            debitCreditCardNumber = txtDebitCreditCardNumber.Text;
            expirationMonth = txtExpirationMonth.Text;
            expirationYear = txtExpirationYear.Text;
            securityCode = txtSecurityCode.Text;
            creditCardType = cbCreditCardType.Text;


            // Save to temp file
            writer.WriteLine(ONE_BOOKING_RECORD_START);
            writer.WriteLine(email);
            writer.WriteLine(dateOfTravel);
            writer.WriteLine(numOfTravelers);
            writer.WriteLine(firstName);
            writer.WriteLine(middleName);
            writer.WriteLine(lastName);
            writer.WriteLine(contactNumber);
            writer.WriteLine(gender);
            writer.WriteLine(birthDate);
            writer.WriteLine(cardHolderName);
            writer.WriteLine(debitCreditCardNumber);
            writer.WriteLine(expirationMonth);
            writer.WriteLine(expirationYear);
            writer.WriteLine(securityCode);
            writer.WriteLine(creditCardType);
            writer.WriteLine(ONE_BOOKING_RECORD_END); ;

            // Close file
            // temp
            writer.Close();
            outFile.Close();

            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtContactNumber.Text != "" && (rbMale.Checked == true || rbFemale.Checked == true) && dtp1.Checked == true && txtCardHolderName.Text != "" && txtDebitCreditCardNumber.Text != "" && txtExpirationMonth.Text != "" && txtExpirationYear.Text != "" && txtSecurityCode.Text != "" && cbCreditCardType.Text != "")
            {
                btnSubmit.Enabled = true;
                lblError2.Visible = false;
            }
            else
            {
                
                lblError2.Visible = true;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
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

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {

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

        private void txtContactNumber_Leave(object sender, EventArgs e)
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
