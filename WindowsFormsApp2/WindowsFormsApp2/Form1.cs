using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           textBoxMajor.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btnRecord.Visible = true;
            
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            textBoxCreateUsername.Enabled = true;
            textBoxCreateUsername.Focus();

            //Declare variables
            string name, major;

            //input from user
            name = textBoxName.Text;
            major = textBoxMajor.Text;

            //display confirmation to user
            lblConfirm.Text = String.Format("Hello {0}, just to confirm, your major is {1}.", name, major);
        }

        private void textBoxCreateUsername_TextChanged(object sender, EventArgs e)
        {
            textBoxCreatePassword.Enabled = true;
        }

        private void textBoxCreatePassword_TextChanged(object sender, EventArgs e)
        {
            btnRecord2.Visible = true;
        }

        private void btnRecord3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHours_TextChanged(object sender, EventArgs e)
        {
            btnRecord3.Visible = true;
        }
    }
}
