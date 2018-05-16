using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txtAge_TextChanged(object sender, EventArgs e)
		{

        }

		private void BtnCalc_Click(object sender, EventArgs e)
		{

        }

        private void btnCalc_Click_1(object sender, EventArgs e)
        {
            //declare variables and constants
            const int COMPACT = 15, MIDSIZE = 25, LUX = 50, EXTRA = 25;
            const int MIN = 18, MAX = 25;
            double age, days, total, fee;
            const double TAX = 1.0775;

            //input from user
            age = Convert.ToDouble(txtAge.Text);
            days = Convert.ToDouble(txtDay.Text);
            fee = Convert.ToDouble(txtDay.Text);

            if (age <= MIN)
                lblTotal.Text = "Too Young.";
            else
            {
                if (age >= MAX)
                    fee = 0;
                else fee = EXTRA;

                if (rdBtnComp.Checked)
                    total = ((COMPACT + fee) * days) * TAX;
                else
                    if (rdBtnMid.Checked)
                    total = ((MIDSIZE + fee) * days) * TAX;
                else
                    total = ((LUX + fee) * days) * TAX;

                //Display total
                /* If you want to display a text, use
                 lblTotal.Text = String.Format("Your total is {0}.", Convert.ToString(total);*/
                lblTotal.Text = String.Format("Your total is {0}.", total.ToString("C"));
            }
        }
    }
}
