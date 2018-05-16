using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inches, centimeters;

            inches = Convert.ToDouble(txtBoxInches.Text); ;
          
            centimeters = inches * 2.54;

            lblCentimetersOutput.Text = String.Format("Your total centimeters are {0}", centimeters);
        }
    }
}
