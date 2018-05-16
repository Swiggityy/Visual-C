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
    public partial class frmCelebrate : Form
    {
        public frmCelebrate()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnFestival2_Click(object sender, EventArgs e)
        {
            string trip = "Festival";
            int airFarePrice;
            int motelPrice;
            int ticketPrice;
            const string FILENAME = "trips.txt";

            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            airFarePrice = 500;
            motelPrice = 214;
            ticketPrice = 150;

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
                airFarePrice = 500 * 2;
                motelPrice = 214 * 2;
                ticketPrice = 150 * 2;

                // Display Book for Two People Form
                BookTrip2P frmBookTripFor2People = new BookTrip2P();
                frmBookTripFor2People.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor2People.Show();
                // this.Hide();
            }
            writer.WriteLine(trip);
            writer.WriteLine(airFarePrice);
            writer.WriteLine(motelPrice);
            writer.WriteLine(ticketPrice);
            // Close file
            // temp
            writer.Close();
            outFile.Close();
        }

        private void lblFestival_Click(object sender, EventArgs e)
        {

        }

        private void btnFestival1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCruise1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDining1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDining2_Click(object sender, EventArgs e)
        {
            string trip = "Dining";
            int airFarePrice;
            int motelPrice;
            int foodPrice;
            const string FILENAME = "trips.txt";

            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            airFarePrice = 510;
            motelPrice = 670;
            foodPrice = 1000;


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
                motelPrice = 670 * 2;
                foodPrice = 1000 * 2;
                // Display Book for Two People Form
                BookTrip2P frmBookTripFor2People = new BookTrip2P();
                frmBookTripFor2People.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor2People.Show();
                // this.Hide();
            }
            writer.WriteLine(trip);
            writer.WriteLine(airFarePrice);
            writer.WriteLine(motelPrice);
            writer.WriteLine(foodPrice);
            // Close file
            // temp
            writer.Close();
            outFile.Close();
        }

        private void btnCruise2_Click(object sender, EventArgs e)
        {
            string trip = "Cruise";
            int ticketPrice;
            const string FILENAME = "trips.txt";

            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            ticketPrice = 6000;


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
                ticketPrice = 6000 * 2;

                // Display Book for Two People Form
                BookTrip2P frmBookTripFor2People = new BookTrip2P();
                frmBookTripFor2People.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor2People.Show();
                // this.Hide();
            }
            writer.WriteLine(trip);
            writer.WriteLine(ticketPrice);
           
            // Close file
            // temp
            writer.Close();
            outFile.Close();
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2.Checked == true)
            {
                lblFestival.Text = "Festival 2 People: Airfare = $1020; Hotel-2 Nights = $428; Ticket Price = $300 Per Day";
                lblDining.Text = "Dining 2 People: Airfare = $1020; Hotel-2 Nights = $1340; Food Price = $2000";
                lblCruise.Text = "Cruise 2 People: Ticket Price = $12060";
            }
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb1.Checked == true)
            {
                lblFestival.Text = "Festival 1 Person: Airfare = $510; Hotel-2 Nights = $214; Ticket Price = $150 Per Day";
                lblDining.Text = "Dining 1 Person: Airfare = $510; Hotel- 2 Nights = $670; Food Price = $1000";
                lblCruise.Text = "Cruise 1 Person: Ticket Price = $6030";
            }
        }

        private void lblCelebration_Click(object sender, EventArgs e)
        {

        }

        private void lblDining_Click(object sender, EventArgs e)
        {

        }
    }
}
