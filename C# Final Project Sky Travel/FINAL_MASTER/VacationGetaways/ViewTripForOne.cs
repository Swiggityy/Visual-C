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
    public partial class ViewTripForOne : Form
    {
        public ViewTripForOne()
        {
            InitializeComponent();
        }

        private void ViewTripForOne_Load(object sender, EventArgs e)
        {
            string bookingRecordStart, email, dateOfTravel, numOfTravelers, trip, firstName, middleName, lastName, contactNumber, gender, cardHolderName;
            string debitCreditCardNumber, expirationMonth, expirationYear, securityCode, birthDate, creditCardType, bookingRecordEnd;
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
            tripLocation = reader2.ReadLine();
            airFarePrice = reader2.ReadLine();
            hotelPrice = reader2.ReadLine(); 
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

            lblResults.Text = String.Format("Package: {0}, AirFare: ${1}, Hotel: ${2}", tripLocation, airFarePrice, hotelPrice);
        }
    }
}
