using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Customers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare Variables and Constants
            string name, eMail;
            const string FILENAME = "customersTemp.txt";
            const string FILENAME2 = "customersPerm.txt";
            // Declare our FileStream and StreamWriter
            // Temporary file
            FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            // Permanent file
            FileStream outFile2 = new FileStream(FILENAME2, FileMode.Append, FileAccess.Write);
            StreamWriter writer2 = new StreamWriter(outFile2);
            
            
            // Input from user
            name = txtName.Text;
            eMail = txtEmail.Text;

          

            // Save to temp file
            writer.WriteLine(name);
            writer.WriteLine(eMail);

            // save to perm file
            writer2.WriteLine(name);
            writer2.WriteLine(eMail);

            // Close file
            // temp
            writer.Close();
            outFile.Close();
            // perm
            writer2.Close();
            outFile2.Close();

            

            // Clear textboxes for next user
            txtName.Text = "";
            txtEmail.Text = "";
            txtName.Focus();

            // Display second form
            frmRead secondForm = new frmRead();
            secondForm.Show();
            this.Hide();
           
        }
    }
}
