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
    public partial class frmRead : Form
    {
        public frmRead()
        {
            InitializeComponent();
        }

        private void frmRead_Load(object sender, EventArgs e)
        {
            // Declare Variables and Constants
            string name2, eMail2, name, eMail;
            const string FILENAME = "customersTemp.txt";
            const string FILENAME2 = "customersPerm.txt";
            
            // Reading Temporary File
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            FileStream inFile2 = new FileStream(FILENAME2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(inFile2);

            // Read Data in from temp file
            name2 = reader.ReadLine();
            eMail2 = reader.ReadLine();

            // Read from permanent file
            name = reader2.ReadLine();
            while(name != null)
            {
                eMail = reader2.ReadLine();
                lblResults.Text += String.Format("{0},  {1}", name, eMail);
                name = reader2.ReadLine();
            }
               

            // Display data
          //  lblResults.Text = String.Format("{0},  {1}", name2, eMail2);

            // read file
            reader.Close();
            inFile.Close();
            reader2.Close();
            inFile2.Close();

            ArrayForm thirdForm = new ArrayForm();
            thirdForm.Show();
            this.Hide();

        }
    }
}
