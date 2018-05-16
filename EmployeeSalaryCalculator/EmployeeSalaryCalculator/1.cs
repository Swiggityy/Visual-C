using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && txtPassword.Text == "XYZ")
            {
                lblWelcome.Text = "Type in your information";
                lblWelcome.ForeColor = Color.Black;
                lblName.Text = "Hours Worked";
                lblPassword.Text = "Pay Rate";
                btnLogIn.Visible = false;
                btnCalculate.Visible = true;
                txtName.Text = "";
                txtPassword.Text = "";


            }
            else
            {
                lblWelcome.Text = "Invalid Login";
                lblWelcome.ForeColor = Color.Red;
                txtName.Text = "";
                txtPassword.Text = "";
            }


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hoursWorked, payRate, total;

            hoursWorked = Convert.ToInt16(txtName.Text);
            payRate = Convert.ToInt16(txtPassword.Text);

            total = hoursWorked * payRate;

            txtResults.Visible = true;
            txtResults.Text = String.Format("{0}", total.ToString("c"));
        }
    }
}
