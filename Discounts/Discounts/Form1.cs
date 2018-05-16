using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discounts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare variables and arrays
            int[] discountRangeLowerLimit = { 1, 13, 50, 100, 200 };
            double[] discounts = { 0, .10, .14, .18, .20 };
            double customerDiscount;
            int numOfItems;
            int sub = discountRangeLowerLimit.Length - 1;

            // Input from user
            numOfItems = Convert.ToInt16(txtQuantity.Text);

            //Search for Discount
            while (sub > 0 && numOfItems < discountRangeLowerLimit[sub])
                --sub;
            //Display Customer Discount
            customerDiscount = discounts[sub];
            lblDiscount.Text = String.Format("Your discount is: {0}", customerDiscount);
        }
    }
}
