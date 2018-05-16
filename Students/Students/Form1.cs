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

namespace Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] firstName = { "Chris", "Frank", "Tim" };
            string[] lastName = { "Nguyen", "Suh", "McMan" };
            int x = 0;
            int arraySize;


            // Loop to count
            while (firstName != null)
                ++x;

            // Calculate array size
            arraySize = x;

            // Create arrays
            firstName = new string[arraySize];
            lastName = new string[arraySize];

            x = Array.BinarySearch(firstName, lastName);

           while (firstName != null && lastName != null)
            {
                firstName[x] = lblName.Text;
                lastName[x] = lblLastName.Text;
            }
            
        }
    }
}
