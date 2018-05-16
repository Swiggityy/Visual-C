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
    public partial class Confirmation2 : Form
    {
        public Confirmation2()
        {
            InitializeComponent();
        }

        private void Confirmation2_Load(object sender, EventArgs e)
        {
            string bookingRecordStart, email, dateOfTravel, numOfTravelers, firstName2, middleName2, lastName2, contactNumber2, gender2, birthDate2, firstName, middleName, lastName, contactNumber, gender;
            string cardHolderName, debitCreditCardNumber, expirationMonth, expirationYear, securityCode, birthDate, creditCardType, bookingRecordEnd;

            string airFarePrice, motelPrice;
            const string FILENAME = "ConfirmationInfo.txt";

            FileStream inFile2 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
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

            firstName2 = reader2.ReadLine();
            middleName2 = reader2.ReadLine();
            lastName2 = reader2.ReadLine();
            contactNumber2 = reader2.ReadLine();
            gender2 = reader2.ReadLine();
            birthDate2 = reader2.ReadLine();

            cardHolderName = reader2.ReadLine();
            debitCreditCardNumber = reader2.ReadLine();
            expirationMonth = reader2.ReadLine();
            expirationYear = reader2.ReadLine();
            securityCode = reader2.ReadLine();
            creditCardType = reader2.ReadLine();
            bookingRecordEnd = reader2.ReadLine();

            lblLoggedInUserEmail.Text = String.Format("(Logged in user: {0})", email);
            lblDateOfTravel2.Text = String.Format("{0})", dateOfTravel);
           
            lblFirstName.Text = String.Format("{0}", firstName);
            lblMiddleName.Text = String.Format("{0}", middleName);
            lblLastName.Text = String.Format("{0}", lastName);
            lblContactNumber.Text = String.Format("{0}", contactNumber);
            lblGender.Text = String.Format("{0}", gender);
            lblBirthDate.Text = String.Format("{0}", birthDate);

            lblFirstName2.Text = String.Format("{0}", firstName2);
            lblMiddleName2.Text = String.Format("{0}", middleName2);
            lblLastName2.Text = String.Format("{0}", lastName2);
            lblContactNumber2.Text = String.Format("{0}", contactNumber2);
            lblGender2.Text = String.Format("{0}", gender2);
            lblBirthDate2.Text = String.Format("{0}", birthDate2);

            lblCardHolderName.Text = String.Format("{0}", cardHolderName);
            lblDebitCreditCardNumber.Text = String.Format("{0}", debitCreditCardNumber);
            lblExpirationDate.Text = String.Format("{0}/{1}", expirationMonth, expirationYear);
            lblSecurityCode.Text = String.Format("{0}", securityCode);
            lblCreditCardType.Text = String.Format("{0}", creditCardType);

            // close file
            reader2.Close();
            inFile2.Close();

            const string FILENAME3 = "trips.txt";

            FileStream inFile3 = new FileStream(FILENAME3, FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(inFile3);

            //Set Global Selected Trip, Airfare and Hotel Cost
            Globals.currentSelectedTrip = reader3.ReadLine();
            Globals.currentSelectedAirfare = reader3.ReadLine();
            Globals.currentSelectedHotelCost = reader3.ReadLine();

            lblResults.Text = String.Format("Package: {0}, AirFare: ${1}, Hotel: ${2}", Globals.currentSelectedTrip, Globals.currentSelectedAirfare, Globals.currentSelectedHotelCost);
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string bookingRecordStart, email, dateOfTravel, numOfTravelers, firstName2, middleName2, lastName2, contactNumber2, gender2, birthDate2, firstName, middleName, lastName, contactNumber, gender;
            string cardHolderName, debitCreditCardNumber, expirationMonth, expirationYear, securityCode, birthDate, creditCardType, bookingRecordEnd;
            string airFarePrice, motelPrice, trip;

            const string FILENAME3 = "trips.txt";
            const string FILENAME = "FinalBookings.txt";
            const string FILENAME2 = "ConfirmationInfo.txt";

            FileStream inFile2 = new FileStream(FILENAME2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(inFile2);
            FileStream inFile3 = new FileStream(FILENAME3, FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(inFile3);

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

            firstName2 = reader2.ReadLine();
            middleName2 = reader2.ReadLine();
            lastName2 = reader2.ReadLine();
            contactNumber2 = reader2.ReadLine();
            gender2 = reader2.ReadLine();
            birthDate2 = reader2.ReadLine();

            cardHolderName = reader2.ReadLine();
            debitCreditCardNumber = reader2.ReadLine();
            expirationMonth = reader2.ReadLine();
            expirationYear = reader2.ReadLine();
            securityCode = reader2.ReadLine();
            creditCardType = reader2.ReadLine();
            trip = reader3.ReadLine();
            airFarePrice = reader3.ReadLine();
            motelPrice= reader3.ReadLine();
            bookingRecordEnd = reader2.ReadLine();

            // Declare our FileStream and StreamWriter
            // close file
            reader2.Close();
            inFile2.Close();
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

            writer2.WriteLine(firstName2);
            writer2.WriteLine(middleName2);
            writer2.WriteLine(lastName2);
            writer2.WriteLine(contactNumber2);
            writer2.WriteLine(gender2);
            writer2.WriteLine(birthDate2);

            writer2.WriteLine(cardHolderName);
            writer2.WriteLine(debitCreditCardNumber);
            writer2.WriteLine(expirationMonth);
            writer2.WriteLine(expirationYear);
            writer2.WriteLine(securityCode);
            writer2.WriteLine(creditCardType);
            writer2.WriteLine(trip);
            writer2.WriteLine(airFarePrice);
            writer2.WriteLine(motelPrice);
            writer2.WriteLine(bookingRecordEnd);

            
            // perm
            writer2.Close();
            outFile2.Close();

            MessageBox.Show("Thank you for booking with Vacation Getaways!");

           // frmWelcome Welcome = new frmWelcome();
           // Welcome.ShowDialog();
           // this.Hide();
        }

        private void ckConfirm_CheckedChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblMiddleName2_Click(object sender, EventArgs e)
        {

        }

        private void lblGender2_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthDate2_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName2_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName2_Click(object sender, EventArgs e)
        {

        }

        private void lblContactNumber2_Click(object sender, EventArgs e)
        {

        }

        private void lblMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblResults_Click(object sender, EventArgs e)
        {

        }

        private void lblDateOfTravel2_Click(object sender, EventArgs e)
        {

        }

        private void lblCreditCardType_Click(object sender, EventArgs e)
        {

        }

        private void lblExpirationDate_Click(object sender, EventArgs e)
        {

        }

        private void lblDebitCreditCardNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblCardHolderName_Click(object sender, EventArgs e)
        {

        }

        private void lblSecurityCode_Click(object sender, EventArgs e)
        {

        }
    }
}
