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
    public partial class frmRelax : Form
    {
      
        public frmRelax()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnYoga2_Click(object sender, EventArgs e)
        {
            string trip = "Yoga";
            int airFarePrice;
            int motelPrice;
            const string FILENAME = "trips.txt";

            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            airFarePrice = 1000;
            motelPrice = 2000;



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
                motelPrice = 2000 * 2;

                // Display Book for Two People Form
                BookTrip2P frmBookTripFor2People = new BookTrip2P();
                frmBookTripFor2People.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor2People.Show();
                // this.Hide();
            }
            writer.WriteLine(trip);
            writer.WriteLine(airFarePrice);
            writer.WriteLine(motelPrice);
            // Close file
            // temp
            writer.Close();
            outFile.Close();
        }

        private void btnHS2_Click(object sender, EventArgs e)
        {
            string trip = "Hot Springs";
            int airFarePrice;
            int motelPrice;
            const string FILENAME = "trips.txt";

            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            airFarePrice = 600;
            motelPrice = 460;



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
                airFarePrice = 600 * 2;
                motelPrice = 460 * 2;


                // Display Book for Two People Form
                BookTrip2P frmBookTripFor2People = new BookTrip2P();
                frmBookTripFor2People.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor2People.Show();
                // this.Hide();
            }
            writer.WriteLine(trip);
            writer.WriteLine(airFarePrice);
            writer.WriteLine(motelPrice);
            // Close file
            // temp
            writer.Close();
            outFile.Close();
        }

        private void btnSpa2_Click(object sender, EventArgs e)
        {
            string trip = "Spa";
            int airFarePrice;
            int motelPrice;
            const string FILENAME = "trips.txt";

            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            airFarePrice = 800;
            motelPrice = 500;


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
                airFarePrice = 800 * 2;
                motelPrice = 500 * 2;

                // Display Book for Two People Form
                BookTrip2P frmBookTripFor2People = new BookTrip2P();
                frmBookTripFor2People.StartPosition = FormStartPosition.CenterScreen;
                frmBookTripFor2People.Show();
                // this.Hide();
            }
            writer.WriteLine(trip);
            writer.WriteLine(airFarePrice);
            writer.WriteLine(motelPrice);
            // Close file
            // temp
            writer.Close();
            outFile.Close();
        }

        private void btnYoga1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHS1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSpa1_Click(object sender, EventArgs e)
        {
           
        }

        private void lblFestival_Click(object sender, EventArgs e)
        {

        }

        private void frmRelax_Load(object sender, EventArgs e)
        {
            
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rdb1.Checked == true)
            {
                lblYoga.Text = "Yoga Retreat 1 Person: Airfare = $1000; Hotel-2 Nights = $2000";
                lblHotSprings.Text = "Hot Springs 1 Person: Airfare = $600; Hotel-2 Nights = $460";
                lblSpa.Text = "Spa 1 Person: Airfare = $800; Hotel-2 Nights = $500";
            }
            
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            lblYoga.Text = "Yoga Retreat 2 People: Airfare = $2000; Hotel-2 Nights = $4000";
            lblHotSprings.Text = "Hot Springs 2 People: Airfare = $1200; Hotel-2 Nights = $920";
            lblSpa.Text = "Spa 2 People: Airfare = $1800; Hotel-2 Nights = $1000";
        }
    }
}
