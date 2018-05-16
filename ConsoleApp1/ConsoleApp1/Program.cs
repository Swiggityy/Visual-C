using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables and constants
            double salesTotal = 0; //accumulator 
            int count = 0; //counter
            double sales, average;
            string id;
            const string MGR = "M0001";

            Console.WriteLine("enter employee ID");
            id = Console.ReadLine();

            while (id != MGR)
            {
                Console.WriteLine("Enter Sales");
                sales = Convert.ToDouble(Console.ReadLine());
                count = count + 1;
                salesTotal = sales;
                Console.WriteLine("enter employee ID");
                id = Console.ReadLine();
            }
            average = salesTotal / count;
            Console.WriteLine("Your total count is {0}, total sales are {1}, and average sales are {2}",count,salesTotal,average);
            Console.ReadLine();
        }
    }
}
