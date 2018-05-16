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

namespace HMWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cityName;
            int[] averageIncome;
            int[] sales;
            int[] empty;
            int blank;
            string all = "All";
            string input;
            int arraySize;
            string cityName1;
            int averageIncome1;
            int sales1;
            int x = 0;
            int sum = 0;
            bool matchFlag = false;

            const string FILENAME = "Store.txt";
            const string FILENAME2 = "TotalSales.Txt";


          
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            input = txtCityName.Text;

            //Loop to Count
            while (reader.ReadLine() != null)
            {
                x++;
            }

            arraySize = x /4 ;

            cityName = new string[arraySize];
            averageIncome = new int[arraySize];
            sales = new int[arraySize];
            empty = new int[arraySize];

            // Return to Beginning of File
            inFile.Seek(0, SeekOrigin.Begin);

            for (int y = 0; y < cityName.Length; y++)
            {
                cityName[y] = reader.ReadLine();
                averageIncome[y] = Convert.ToInt32(reader.ReadLine());
                sales[y] = Convert.ToInt32(reader.ReadLine());
                empty[y] = Convert.ToInt32(reader.ReadLine());

                if (cityName[y] == input)
                {
                    cityName1 = cityName[y];
                    averageIncome1 = Convert.ToInt32(averageIncome[y]);
                    sales1 = Convert.ToInt32(sales[y]);
                    blank = Convert.ToInt32(empty[y]);
                    sum = sales[y]++;
                    matchFlag = true;

                    if (matchFlag == true)
                    {
                        
                        lblResults.Text = String.Format("\nCity Name: {0}, Average Income: {1}, 2017 Sales: {2}", cityName1, averageIncome1.ToString("C2"), sales1.ToString("C2"));
                        txtCityName.Visible = false;
                        btnCalculate.Visible = false;
                    }

                }

                if (txtCityName.Text == all)
                {
                    cityName1 = cityName[y];
                    averageIncome1 = Convert.ToInt32(averageIncome[y]);
                    sales1 = Convert.ToInt32(sales[y]);
                    blank = Convert.ToInt32(empty[y]);
                    sum += sales[y];
                    matchFlag = true;

                    if(matchFlag == true)
                    {
                        lblResults.Text += String.Format("\nCity Name: {0}, Average Income: {1}, 2017 Sales: {2} running Total: {3}", cityName1, averageIncome1.ToString("C2"), sales1.ToString("C2"), sum);
                        txtCityName.Visible = false;
                        btnCalculate.Visible = false;

                       
                    }
                }
            }
            FileStream outFile = new FileStream(FILENAME2, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            writer.WriteLine(sum);

            writer.Close();
            outFile.Close();
        }
    }
}
