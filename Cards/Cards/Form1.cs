using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Created by Chris Nguyen 03/06/17

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare variables and constants
            const int GIFTCARDS = 100, MIN = 20, MAX = 50;
            const double DISCOUNT1 = .98, DISCOUNT2 = .97;
            double amount, total;

            //input from user
            amount = Convert.ToDouble(txtAmount.Text);

            //if and else statements
            if (rdBtnNo.Checked)
                total = amount * GIFTCARDS;
            else
            {
                if (MAX > amount && amount > MIN)
                    total = (GIFTCARDS * amount) * DISCOUNT1;
                else
                    total = amount * GIFTCARDS;

                if (amount > MAX)
                    total = (GIFTCARDS * amount) * DISCOUNT2;
                else
                    total = (GIFTCARDS * amount) * DISCOUNT1;
            }
         lblTotal.Text = String.Format("Hi, your total is {0}.", total.ToString("C"));
        }
    }
}
