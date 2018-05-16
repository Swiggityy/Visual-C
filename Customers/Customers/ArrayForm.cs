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
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void ArrayForm_Load(object sender, EventArgs e)
        {
            // Declare constanstants, arrays, and variables
            string[] name;
            string[] eMail;
            int x = 0;
            int arraySize;
            const string FILENAME2 = "customersPerm.txt";
            FileStream inFile2 = new FileStream(FILENAME2, FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(inFile2);

            // Loop to count
            while (reader2.ReadLine() != null)
                ++x;

            // close file
            /*reader2.Close();
            inFile2.Close();*/

            // Calculate array size
            arraySize = x / 2;

            // Create arrays
            name = new string[arraySize];
            eMail = new string[arraySize];
            
            // Return to Beginning of File
            inFile2.Seek(0, SeekOrigin.Begin);

           /* FileStream inFile3 = new FileStream(FILENAME2, FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(inFile3); */

            for (int y = 0; y < name.Length; ++y)
            {
                name[y] = reader3.ReadLine();
                eMail[y] = reader3.ReadLine();

                lblResults.Text += name[y];
            }
            reader2.Close();
            inFile2.Close();
        }
    }
}
