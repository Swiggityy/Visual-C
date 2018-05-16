using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBirthMonth_Click(object sender, EventArgs e)
        {
            const int max = 12;
            const int min = 1;
            int month;

            month = Convert.ToInt32(txtBoxMonth.Text);

            if (month > max || month < min)
            {
                lblResult.Text = "Invalid";
                txtBoxMonth.BackColor = Color.Red;
                txtBoxMonth.Focus();
            }
            else
            {
                lblResult.Text = "Goodjob!";
                txtBoxMonth.BackColor = Color.White;
            }
        }
    }
}
