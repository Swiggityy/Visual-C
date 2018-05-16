using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*  Created by:  L. Marcoulides
 *  Created on 2/15/18
 *  Program:  Calculates pay */

namespace payroll
{
    public partial class frmPay : Form
    {
        // Declare public variables
        string name;

        public frmPay()
        {
            InitializeComponent();
        }

        private void lblHours_Click(object sender, EventArgs e)
        {

        }

        private void frmPay_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare variables
           
            double hrs, rate, pay;

            // input data from user
            name = txtName.Text;
            hrs = Convert.ToDouble(txtHrs.Text);
            rate = Convert.ToDouble(txtRate.Text);

            // calculate pay
            pay = hrs * rate;

            // Display Results
            lblResults.Text = String.Format("{0}, your pay is {1}.", name, pay.ToString("C"));
            // put focus on username textbox
            txtUserName.Focus();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //  enable hrs textbox
            txtHrs.Enabled = true;
        }

        private void txtHrs_TextChanged(object sender, EventArgs e)
        {
            // enable the rate textbox
            txtRate.Enabled = true;
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            // Make calculate button visible
            btnCalc.Visible = true;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // Declare variables
            string userName, password;

            // Input from user
            userName = txtUserName.Text;
            password = txtPassword.Text;

            // Display thankyou
            lblThankYou.Text = String.Format("{0}, thank you for choosing a username and password", name);
        }
    }
}
