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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            string bookingRecordStart, email, dateOfTravel, numOfTravelers, trip, firstName, middleName, lastName, contactNumber, gender, cardHolderName; 
            string debitCreditCardNumber, expirationMonth, expirationYear, securityCode, birthDate, creditCardType, bookingRecordEnd;
            string airFarePrice, motelPrice;
            const string FILENAME2 = "ConfirmationInfo.txt";
           

            FileStream inFile2 = new FileStream(FILENAME2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(inFile2);

            // email = Globals.loggedInUsersEmail;
            // if (email == "")
            //   email = "NoLoggedInEmail";
                bookingRecordStart = reader2.ReadLine();
                email = reader2.ReadLine();
                dateOfTravel = reader2.ReadLine();
                numOfTravelers = reader2.ReadLine();
                firstName = reader2.ReadLine();
                middleName = reader2.ReadLine();
                lastName = reader2.ReadLine();
                contactNumber = reader2.ReadLine();
                gender = reader2.ReadLine();
                birthDate = reader2.ReadLine();
                cardHolderName = reader2.ReadLine();
                debitCreditCardNumber = reader2.ReadLine();
                expirationMonth = reader2.ReadLine();
                expirationYear = reader2.ReadLine();
                securityCode = reader2.ReadLine();
                creditCardType = reader2.ReadLine();
                bookingRecordEnd = reader2.ReadLine();

                lblLoggedInUserEmail.Text = String.Format("(Logged in User: {0})", email);
                lblDateOfTravel2.Text = String.Format("{0}", dateOfTravel);

                lblFirstName.Text = String.Format("{0}", firstName);
                lblMiddleName.Text = String.Format("{0}", middleName);
                lblLastName.Text = String.Format("{0}", lastName);
                lblContactNumber.Text = String.Format("{0}", contactNumber);
                lblGender.Text = String.Format("{0}", gender);
                lblBirthDate.Text = String.Format("{0}", birthDate);
                lblCardHolderName.Text = String.Format("{0}", cardHolderName);
                lblDebitCreditCardNumber.Text = String.Format("{0}", debitCreditCardNumber);
                lblExpireMonth.Text = String.Format("{0}/{1}", expirationMonth, expirationYear);
                lblExpireYear.Text = String.Format("{0}", securityCode);
                lblCreditCardType.Text = String.Format("{0}", creditCardType);

            // close file
            reader2.Close();
            inFile2.Close();

            const string FILENAME3 = "trips.txt";

            FileStream inFile3 = new FileStream(FILENAME3, FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(inFile3);

            Globals.currentSelectedTrip = reader3.ReadLine();
            Globals.currentSelectedAirfare = reader3.ReadLine();
            Globals.currentSelectedHotelCost = reader3.ReadLine();

            lblResults.Text = String.Format("Package: {0}, AirFare: ${1}, Hotel: ${2}", Globals.currentSelectedTrip, Globals.currentSelectedAirfare, Globals.currentSelectedHotelCost);
        }

        private void ckConfirm_CheckedChanged(object sender, EventArgs e)
        {
                btnCreate.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Declare Variable and Constants
            string bookingRecordStart, email, dateOfTravel, numOfTravelers, firstName, middleName, lastName, contactNumber, gender, cardHolderName;
            string debitCreditCardNumber, expirationMonth, expirationYear, securityCode, birthDate, creditCardType, bookingRecordEnd;
            const string FILENAME = "FinalBookings.txt";
            const string FILENAME2 = "ConfirmationInfo.txt";

            FileStream inFile2 = new FileStream(FILENAME2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(inFile2);
            bookingRecordStart = reader2.ReadLine();
            email = reader2.ReadLine();
            dateOfTravel = reader2.ReadLine();
            numOfTravelers = reader2.ReadLine();
            firstName = reader2.ReadLine();
            middleName = reader2.ReadLine();
            lastName = reader2.ReadLine();
            contactNumber = reader2.ReadLine();
            gender = reader2.ReadLine();
            birthDate = reader2.ReadLine();
            cardHolderName = reader2.ReadLine();
            debitCreditCardNumber = reader2.ReadLine();
            expirationMonth = reader2.ReadLine();
            expirationYear = reader2.ReadLine();
            securityCode = reader2.ReadLine();
            creditCardType = reader2.ReadLine();
            bookingRecordEnd = reader2.ReadLine();

            // Declare our FileStream and StreamWriter
            // Permanent file
            FileStream outFile2 = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
            StreamWriter writer2 = new StreamWriter(outFile2);
            writer2.WriteLine(bookingRecordStart);
            writer2.WriteLine(email);
            writer2.WriteLine(dateOfTravel);
            writer2.WriteLine(numOfTravelers);
            writer2.WriteLine(firstName);
            writer2.WriteLine(middleName);
            writer2.WriteLine(lastName);
            writer2.WriteLine(contactNumber);
            writer2.WriteLine(gender);
            writer2.WriteLine(birthDate);
            writer2.WriteLine(cardHolderName);
            writer2.WriteLine(debitCreditCardNumber);
            writer2.WriteLine(expirationMonth);
            writer2.WriteLine(expirationYear);
            writer2.WriteLine(securityCode);

            writer2.WriteLine(creditCardType);
            writer2.WriteLine(Globals.currentSelectedTrip);
            writer2.WriteLine(Globals.currentSelectedAirfare);
            writer2.WriteLine(Globals.currentSelectedHotelCost);
            writer2.WriteLine(bookingRecordEnd);

            // close file
            reader2.Close();
            inFile2.Close();
            // perm
            writer2.Close();
            outFile2.Close();

            MessageBox.Show("Thank you for booking with Vacation Getaways!");

          // Don't need to create another welcome form there is already one up
          //  frmWelcome Welcome = new frmWelcome();
          // Welcome.ShowDialog();
           this.Hide();

        }

        private void lblError1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblResults_Click(object sender, EventArgs e)
        {

        }
    }
}
