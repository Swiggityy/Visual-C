using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacationGetaways
{
    public partial class WarningOnCancel : Form
    {
        public bool backToNewAccountSelected { get; set; }

        public WarningOnCancel()
        {
            InitializeComponent();
        }

        private void WarningOnCancel_Load(object sender, EventArgs e)
        {

        }

        private void btnBacktoNewAccount_Click(object sender, EventArgs e)
        {
            backToNewAccountSelected = true;
            Dispose();
        }

        private void btnBacktoTripSelection_Click(object sender, EventArgs e)
        {
            backToNewAccountSelected = false;
            Dispose();
        }
    }
}
