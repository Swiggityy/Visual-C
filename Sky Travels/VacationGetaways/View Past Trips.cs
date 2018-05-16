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
enum TripBookingFields
{
    BookingStart_Field,
    Email_Field,
    DateOfTravel_Field,
    NumOfTravelers_Field,
    FirstName1_Field,
    MiddleName1_Field,
    LastName1_Field,
    ContactNumber1_Field,
    Gender1__Field,
    BirthDate1_Field,
    FirstName2_Field,
    MiddleName2_Field,
    LastName2_Field,
    ContactNumber2_Field,
    Gender2_Field,
    BirthDate2_Field,
    CardHolderName_Field,
    DebitCreditCardNumber_Field,
    ExpirationMonth_Field,
    ExpirationYear_Field,
    SecurityCode_Field,
    CreditCardType_Field,
    TripDescription_Field,
    TripAirfare_Field,
    TripHotelPrice_Field,
    BookingEnd_Field
}




namespace VacationGetaways
{
    public partial class frmViewPastTrips : Form
    {
        const int MAX_TRIPS_TO_DISPLAY = 30;
        string[][] tripArray = new string[MAX_TRIPS_TO_DISPLAY][];

        public frmViewPastTrips()
        {
            InitializeComponent();
            lblViewPastTrip2.Text = String.Format(" {0}", Globals.loggedInUsersEmail);
        }

        private void frmViewPastTrips_Load(object sender, EventArgs e)
        {
            //Declare Constants and Variables
            const string TWO_BOOKING_RECORD_START = "**Two Person Booking Record Start**";
            const string TWO_BOOKING_RECORD_END = "**Two Person Booking Record End**";

            string bookingRecordStartMark;
            string emailFromFile;
            string dateOfTravelFromFile;
            string numOfTravelersFromFile;
            string firstName1FromFile;
            string middleName1FromFile;
            string lastName1FromFile;
            string contact1NumberFromFile;
            string gender1FromFile;
            string birthDate1FromFile;

            string firstName2FromFile;
            string middleName2FromFile;
            string lastName2FromFile;
            string contact2NumberFromFile;
            string gender2FromFile;
            string birthDate2FromFile;

            string cardHolderNameFromFile;
            string debitCreditCardNumberFromFile;
            string expirationMonthFromFile;
            string expirationYearFromFile;
            string securityCodeFromFile;

            string creditCardTypeFromFile;
            string tripDescFromFile;
            string tripAirfareFromFile;
            string tripHotelPriceFromFile;

            string bookingRecordEndMark;

            int x = 0;
            //int arraySize;
            const string FINAL_BOOKINGS = "FinalBookings.txt";
            bool foundMatchingRecord = false;
            int numberOfMatchingRecords = 0;
            int tripFieldIndex, tripIndex;
            string numOfTravelersString;

            //Set up file reading variables
            FileStream bookingsOutFile = new FileStream(FINAL_BOOKINGS, FileMode.Open, FileAccess.Read);
            StreamReader bookingsFileReader = new StreamReader(bookingsOutFile);

            //Read File file entry in case file is empty it will fail the first While test
            bookingRecordStartMark = bookingsFileReader.ReadLine();
            while (!bookingsFileReader.EndOfStream)
            {
                emailFromFile = bookingsFileReader.ReadLine();
                dateOfTravelFromFile = bookingsFileReader.ReadLine();
                numOfTravelersFromFile = bookingsFileReader.ReadLine();
                firstName1FromFile = bookingsFileReader.ReadLine();
                middleName1FromFile = bookingsFileReader.ReadLine();
                lastName1FromFile = bookingsFileReader.ReadLine();
                contact1NumberFromFile = bookingsFileReader.ReadLine();
                gender1FromFile = bookingsFileReader.ReadLine();
                birthDate1FromFile = bookingsFileReader.ReadLine();

                if (bookingRecordStartMark == TWO_BOOKING_RECORD_START)
                {
                    firstName2FromFile = bookingsFileReader.ReadLine();
                    middleName2FromFile = bookingsFileReader.ReadLine();
                    lastName2FromFile = bookingsFileReader.ReadLine();
                    contact2NumberFromFile = bookingsFileReader.ReadLine();
                    gender2FromFile = bookingsFileReader.ReadLine();
                    birthDate2FromFile = bookingsFileReader.ReadLine();
                }
                else
                {
                    firstName2FromFile = "*";
                    middleName2FromFile = "*";
                    lastName2FromFile = "*";
                    contact2NumberFromFile = "*";
                    gender2FromFile = "*";
                    birthDate2FromFile = "*";
                }

                cardHolderNameFromFile = bookingsFileReader.ReadLine();
                debitCreditCardNumberFromFile = bookingsFileReader.ReadLine();
                expirationMonthFromFile = bookingsFileReader.ReadLine();
                expirationYearFromFile = bookingsFileReader.ReadLine();
                securityCodeFromFile = bookingsFileReader.ReadLine();
                creditCardTypeFromFile = bookingsFileReader.ReadLine();
                tripDescFromFile = bookingsFileReader.ReadLine();
                tripAirfareFromFile = bookingsFileReader.ReadLine();
                tripHotelPriceFromFile = bookingsFileReader.ReadLine();
                bookingRecordEndMark = bookingsFileReader.ReadLine();

                //If we have a match on this record then assign details of this trip record into the tripArray for display later
                if (Globals.loggedInUsersEmail == emailFromFile)
                {
                    foundMatchingRecord = true;

                    //Allocate the next set of fields for this booking in the tripArray
                    tripArray[numberOfMatchingRecords] = new string[(int)(TripBookingFields.BookingEnd_Field) + 1];
                    //Populate all the fields with an * character so we can tell later if they are blank
                    for (tripFieldIndex = 0; tripFieldIndex < (int)(TripBookingFields.BookingEnd_Field); tripFieldIndex++)
                        tripArray[numberOfMatchingRecords][tripFieldIndex] = "*";

                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.BookingStart_Field)] = bookingRecordStartMark;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.Email_Field)] = emailFromFile;

                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.DateOfTravel_Field)] = dateOfTravelFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.NumOfTravelers_Field)] = numOfTravelersFromFile;

                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.FirstName1_Field)] = firstName1FromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.MiddleName1_Field)] = middleName1FromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.LastName1_Field)] = lastName1FromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.ContactNumber1_Field)] = contact1NumberFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.Gender1__Field)] = gender1FromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.BirthDate1_Field)] = birthDate1FromFile;

                    if (bookingRecordStartMark == TWO_BOOKING_RECORD_START)
                    {
                        tripArray[numberOfMatchingRecords][(int)(TripBookingFields.FirstName2_Field)] = firstName2FromFile;
                        tripArray[numberOfMatchingRecords][(int)(TripBookingFields.MiddleName2_Field)] = middleName2FromFile;
                        tripArray[numberOfMatchingRecords][(int)(TripBookingFields.LastName2_Field)] = lastName2FromFile;
                        tripArray[numberOfMatchingRecords][(int)(TripBookingFields.ContactNumber1_Field)] = contact2NumberFromFile;
                        tripArray[numberOfMatchingRecords][(int)(TripBookingFields.Gender2_Field)] = gender2FromFile;
                        tripArray[numberOfMatchingRecords][(int)(TripBookingFields.BirthDate2_Field)] = birthDate2FromFile;
                    }

                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.CardHolderName_Field)] = cardHolderNameFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.DebitCreditCardNumber_Field)] = debitCreditCardNumberFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.ExpirationMonth_Field)] = expirationMonthFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.ExpirationYear_Field)] = expirationYearFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.SecurityCode_Field)] = securityCodeFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.CreditCardType_Field)] = creditCardTypeFromFile;

                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.TripDescription_Field)] = tripDescFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.TripAirfare_Field)] = tripAirfareFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.TripHotelPrice_Field)] = tripHotelPriceFromFile;
                    tripArray[numberOfMatchingRecords][(int)(TripBookingFields.BookingEnd_Field)] = bookingRecordEndMark;
                    numberOfMatchingRecords++;
                }
                else
                {


                }

                //Read the first element of the next record for the While Loop test
                bookingRecordStartMark = bookingsFileReader.ReadLine();
            }

            //Close the FinalBooking.Txt file
            bookingsOutFile.Close();
            bookingsFileReader.Close();

            List<string> tripArrayListBox = new List<string>();
            for (tripIndex = 0; tripIndex < numberOfMatchingRecords; tripIndex++)
            {

                if (tripArray[tripIndex][(int)(TripBookingFields.FirstName2_Field)] == "*")
                    numOfTravelersString = "1";
                else
                    numOfTravelersString = "2";

                listPastTrips.Items.Add(
                    new ListViewItem(new string[] { tripArray[tripIndex][(int)(TripBookingFields.DateOfTravel_Field)],
                                                    tripArray[tripIndex][(int)(TripBookingFields.TripDescription_Field)],
                                                    tripArray[tripIndex][(int)(TripBookingFields.NumOfTravelers_Field)],
                                                    String.Format("{0:C2}",tripArray[tripIndex][(int)(TripBookingFields.TripAirfare_Field)]),
                                                    String.Format("{0:C}", tripArray[tripIndex][(int)(TripBookingFields.TripHotelPrice_Field)])
                                                  }));


            }
            listPastTrips.FullRowSelect = true;
            tripIndex = listPastTrips.SelectedItems.Count;

            //Now Show we have not matches or automatically select the first row for the user
            if (foundMatchingRecord == false)
                lblNoTripsFound.Text = "No Past Trips Found for This User";
            else
                listPastTrips.Items[0].Selected = true;

        }

        private void listPastTrips_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tripIndex;
            int listViewRowSelected;
            int numOfRowsToSearch;

            listViewRowSelected = listPastTrips.SelectedItems.Count;
            //      if (listViewRowSelected  0)
            //        btnViewTripDetails.Enabled = false;
            numOfRowsToSearch = listPastTrips.Items.Count;

            for (tripIndex = 1; tripIndex <= numOfRowsToSearch; tripIndex++)
            {
                if (listPastTrips.Items[tripIndex - 1].Selected == true)
                {
                    // Globals.tripViewSelectedTripIndex = listPastTrips.SelectedItems.Count;
                    Globals.tripViewSelectedTripIndex = tripIndex - 1;
                    btnViewTripDetails.Enabled = true;
                }
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnViewTripDetails_Click(object sender, EventArgs e)
        {
            int tripIndexSelected;
            tripIndexSelected = Globals.tripViewSelectedTripIndex;

            string email, dateOfTravel, numOfTravelers, firstName, middleName, lastName, contactNumber, gender, cardHolderName, debitCreditCardNumber;
            string expirationMonth, expirationYear, securityCode, birthDate, creditCardType, tripDate;
            const string FILENAME = "ViewTripDetails.Txt";
            const string ONE_BOOKING_RECORD_START = "**One Person Booking Record Start**";
            const string ONE_BOOKING_RECORD_END = "**One Person Booking Record End**";

            // Declare our FileStream and StreamWriter
            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            //Set the email from the GlobalEmail variable assigned in the Login form
            //Just in case it got here without the email set, then set it to NoEmailEntered
            email = Globals.loggedInUsersEmail;
            if (email == "")
                email = "NoEmailEntered";

            // Save to temp file
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.BookingStart_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.Email_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.DateOfTravel_Field)]);

            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.NumOfTravelers_Field)]);

            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.FirstName1_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.MiddleName1_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.LastName1_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.ContactNumber1_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.Gender1__Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.BirthDate1_Field)]);

            if (tripArray[tripIndexSelected][(int)(TripBookingFields.NumOfTravelers_Field)] == "2")
            {
                writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.FirstName2_Field)]);
                writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.MiddleName2_Field)]);
                writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.LastName2_Field)]);
                writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.ContactNumber1_Field)]);
                writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.Gender2_Field)]);
                writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.BirthDate2_Field)]);
            }
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.CardHolderName_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.DebitCreditCardNumber_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.ExpirationMonth_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.ExpirationYear_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.SecurityCode_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.CreditCardType_Field)]);

            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.TripDescription_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.TripAirfare_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.TripHotelPrice_Field)]);
            writer.WriteLine(tripArray[tripIndexSelected][(int)(TripBookingFields.BookingEnd_Field)]);

            //Close Temp Files used to communicate data to the View Trip Details Screens
            writer.Close();
            outFile.Close();

            //If the NumOfTravelers is 1 then call and show details form for one traveler, else call the two traveler form
            if (tripArray[tripIndexSelected][(int)(TripBookingFields.NumOfTravelers_Field)] == "1")
            {
                ViewTripForOne viewTripForOne = new ViewTripForOne();
                viewTripForOne.StartPosition = FormStartPosition.CenterScreen;
                viewTripForOne.ShowDialog();
                // this.Close();
            }
            else
            {
                ViewTripForTwo viewTripForTwo = new ViewTripForTwo();
                viewTripForTwo.StartPosition = FormStartPosition.CenterScreen;
                viewTripForTwo.ShowDialog();
                // this.Close();
            }

        }
    }
}







