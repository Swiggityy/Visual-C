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
    public partial class frmCulture : Form
    {
        public frmCulture()
        {
            InitializeComponent();
        }

        private void lblTravelers_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCulture2_Click(object sender, EventArgs e)
        {

        }

        private void btnHawaii2_Click(object sender, EventArgs e)
        {
            string trip = "Hawaii";
            int airFarePrice;
            int motelPrice;
            int foodTour;
            int hikingTour;
            const string FILENAME = "trips.txt";

            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            airFarePrice = 510;
            motelPrice = 293;
            foodTour = 100;
            hikingTour = 100;


            if (rdb1.Checked == true)
            {
                // Display Book for 1 Person Form
                BookTrip1P frmBookTripFor1Person = new BookTrip1P();
                frmBookTripFor1Person.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor1Person.Show();
                // this.Hide();
            }
            if (rdb2.Checked == true)
            {
                airFarePrice = 510 * 2;
                motelPrice = 293 * 2;
                foodTour = 100 * 2;
                hikingTour = 100 * 2;

                // Display Book for Two People Form
                BookTrip2P frmBookTripFor2People = new BookTrip2P();
                frmBookTripFor2People.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor2People.Show();
                // this.Hide();
            }
            writer.WriteLine(trip);
            writer.WriteLine(airFarePrice);
            writer.WriteLine(motelPrice);
            writer.WriteLine(foodTour);
            writer.WriteLine(hikingTour);
            // Close file
            // temp
            writer.Close();
            outFile.Close();
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb1.Checked == true)
            {
                lblHawaii.Text = "Hawaii 1 Person: Airfare = $510; Hotel-2 Nights = $293; Food Tour = $99; Hiking Tour = $100";
                lblJapan.Text = "Japan 1 Person: Airfare-$1020; Hotel-2 Nights $71; Guided Tour + Food Tour = $550";
                lblSingapore.Text = "Singapore 1 Person: Airfare = $1000; Hotel-2 Nights = $350; Tour = $100; Sightseeing + Food = $120";
            }
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2.Checked == true)
            {
                lblHawaii.Text = "Hawaii 2 People: Airfare = $1020; Hotel-2 Nights = $586; Food Tour = $198; Hiking Tour = $200";
                lblJapan.Text = "Japan 2 People: Airfare = $2040; Hotel-2 Nights = $142; Guided Tour + Food Tour = $1100";
                lblSingapore.Text = "Singapore 2 People: Airfare = $1000; Hotel-2 Nights = $700; Tour = $200; Sightseeing + Food = $240";
            }

        }

        private void btnJapan2_Click(object sender, EventArgs e)
        {
            string trip = "Japan";
            int airFarePrice;
            int motelPrice;
            int guidedTour;

            const string FILENAME = "trips.txt";

            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            airFarePrice = 1020;
            motelPrice = 71;
            guidedTour = 550;


            if (rdb1.Checked == true)
            {
                // Display Book for 1 Person Form
                BookTrip1P frmBookTripFor1Person = new BookTrip1P();
                frmBookTripFor1Person.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor1Person.Show();
                //this.Hide();
            }
            if (rdb2.Checked == true)
            {
                airFarePrice = 1020 * 2;
                motelPrice = 71 * 2;
                guidedTour = 550 * 2;

                // Display Book for Two People Form
                BookTrip2P frmBookTripFor2People = new BookTrip2P();
                frmBookTripFor2People.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor2People.Show();
                //this.Hide();
            }
            writer.WriteLine(trip);
            writer.WriteLine(airFarePrice);
            writer.WriteLine(motelPrice);
            writer.WriteLine(guidedTour);
            // Close file
            // temp
            writer.Close();
            outFile.Close();
        }

        private void btnSingapore2_Click(object sender, EventArgs e)
        {
            string trip = "Singapore";
            int airFarePrice;
            int motelPrice;
            int tour;
            int foodTour;
            const string FILENAME = "trips.txt";

            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            airFarePrice = 1000;
            motelPrice = 350;
            tour = 100;
            foodTour = 120;

            if (rdb1.Checked == true)
            {
                // Display Book for 1 Person Form
                BookTrip1P frmBookTripFor1Person = new BookTrip1P();
                frmBookTripFor1Person.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor1Person.Show();
                // this.Hide();
            }
            if (rdb2.Checked == true)
            {
                airFarePrice = 1000 * 2;
                motelPrice = 350 * 2;
                tour = 100 * 2;
                foodTour = 120 * 2;

                // Display Book for Two People Form
                BookTrip2P frmBookTripFor2People = new BookTrip2P();
                frmBookTripFor2People.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor2People.Show();
                // this.Hide();
            }
            writer.WriteLine(trip);
            writer.WriteLine(airFarePrice);
            writer.WriteLine(motelPrice);
            writer.WriteLine(tour);
            writer.WriteLine(foodTour);
            // Close file
            // temp
            writer.Close();
            outFile.Close();
        }

        private void lblJapan_Click(object sender, EventArgs e)
        {

        }

        private void btnHawaii1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnJapan1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSingapore1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
