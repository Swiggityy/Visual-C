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
    public partial class ViewTripForTwo : Form
    {
        public ViewTripForTwo()
        {
            InitializeComponent();
        }

        private void ViewTripForTwo_Load(object sender, EventArgs e)
        {
            string bookingRecordStart, email, dateOfTravel, numOfTravelers;
            string firstName1, middleName1, lastName1, contactNumber1, gender1, birthDate1;
            string firstName2, middleName2, lastName2, contactNumber2, gender2, birthDate2;
            string cardHolderName, debitCreditCardNumber, expirationMonth, expirationYear, securityCode, creditCardType, bookingRecordEnd;
            string tripLocation, airFarePrice, hotelPrice;
            const string FILENAME2 = "ViewTripDetails.Txt";

            FileStream inFile2 = new FileStream(FILENAME2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(inFile2);

            // email = Globals.loggedInUsersEmail;
            // if (email == "")
            //   email = "NoLoggedInEmail";
            bookingRecordStart = reader2.ReadLine();
            email = reader2.ReadLine();
            dateOfTravel = reader2.ReadLine();
            numOfTravelers = reader2.ReadLine();

            firstName1 = reader2.ReadLine();
            middleName1 = reader2.ReadLine();
            lastName1 = reader2.ReadLine();
            contactNumber1 = reader2.ReadLine();
            gender1 = reader2.ReadLine();
            birthDate1 = reader2.ReadLine();

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
            tripLocation = reader2.ReadLine();
            airFarePrice = reader2.ReadLine();
            hotelPrice = reader2.ReadLine();
            bookingRecordEnd = reader2.ReadLine();


            lblLoggedInUserEmail.Text = String.Format("(Logged in User: {0})", email);
            lblDateOfTravel2.Text = String.Format("{0}", dateOfTravel);

            lblFirstName1Data.Text = String.Format("{0}", firstName1);
            lblMidName1Data.Text = String.Format("{0}", middleName1);
            lblLastName1Data.Text = String.Format("{0}", lastName1);
            lblContact1Data.Text = String.Format("{0}", contactNumber1);
            lblGender1Data.Text = String.Format("{0}", gender1);
            lblDateBirth1Data.Text = String.Format("{0}", birthDate1);

            lblFirstName2Data.Text = String.Format("{0}", firstName2);
            lblMidName2Data.Text = String.Format("{0}", middleName2);
            lblLastName2Data.Text = String.Format("{0}", lastName2);
            lblContact2Data.Text = String.Format("{0}", contactNumber2);
            lblGender2Data.Text = String.Format("{0}", gender2);
            lblDateBirth2Data.Text = String.Format("{0}", birthDate2);

            lblCardHolderName.Text = String.Format("{0}", cardHolderName);
            lblDebitCreditCardNumber.Text = String.Format("{0}", debitCreditCardNumber);
            lblExpireMonth.Text = String.Format("{0}/{1}", expirationMonth, expirationYear);
            lblExpireYear.Text = String.Format("{0}", securityCode);
            lblCreditCardType.Text = String.Format("{0}", creditCardType);

            // close file
            reader2.Close();
            inFile2.Close();

            lblResults.Text = String.Format("Package: {0}, AirFare: ${1}, Hotel: ${2}", tripLocation, airFarePrice, hotelPrice);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
