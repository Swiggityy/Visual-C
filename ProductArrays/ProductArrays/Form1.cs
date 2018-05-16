using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] prodNumber = { 101, 108, 201, 213 };
            double[] prices = { .89, 1.23, 3.50, .69 };
            string[] descriptions = { "hammer", "gum", "record", "gun" };
            int itemOrdered;
            double itemPrice = 0;
            bool matchFlag = false;

            // input from user
            itemOrdered = Convert.ToInt16(txtProductNumber.Text);
            for (int x = 0; x < prodNumber.Length; ++x)
            {
                if (itemOrdered == prodNumber[x])
                {
                    itemPrice = prices[x];
                    matchFlag = true;
                }  
            }
            if(matchFlag == true)
                lblPrice.Text = String.Format("{0}", itemPrice.ToString("C"));
            else
                lblPrice.Text = "Item not found";
        }
    }
}
