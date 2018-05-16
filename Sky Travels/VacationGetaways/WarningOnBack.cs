using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacationGetaways
{
    public partial class WarningOnBack : Form
    {
        public bool backToBookingSelected { get; set; }

        public WarningOnBack()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBacktoBooking_Click(object sender, EventArgs e)
        {
            backToBookingSelected = true;
            Dispose();
        }

        private void btnBacktoTripSelection_Click(object sender, EventArgs e)
        {
            backToBookingSelected = false;
            Dispose();
        }

        private void WarningOnBack_Load(object sender, EventArgs e)
        {

        }
    }
}
