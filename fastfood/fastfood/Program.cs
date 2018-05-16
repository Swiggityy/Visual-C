using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Created by:  L. Marcoulides
 * Created on 3/13/18
 * Program calculates totals for fast food restaurant */

namespace fastfood
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare constants and variables
            const int STOP = -1;
            const double TAX = .0775;
            const double HAM = 3, FF = 2, COKE = 1;
            int numHam, numFF, numCoke;
            double owed;
            double totalHam = 0, totalFF = 0, totalCoke = 0;
            double totalOwed = 0;

            // input hamburgers (initialize loop control variable )
            Console.WriteLine("Enter number of hamburgers ordered");
            numHam = Convert.ToInt16(Console.ReadLine());

            while(numHam != STOP)
            {
                // Input rest of order
                Console.WriteLine("Enter number of french fries ordered");
                numFF = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter number of cokes ordered");
                numCoke = Convert.ToInt16(Console.ReadLine());

                // calculate amount owed
                owed = (numHam * HAM + numFF * FF + numCoke * COKE) * (1 + TAX);
                // Display results to user
                Console.WriteLine("You owe {0}", owed.ToString("C"));

                // Total up all sales
                totalHam += numHam;
                totalFF += numFF;
                totalCoke += numCoke;
                totalOwed += owed;

                Console.WriteLine("Enter number of hamburgers ordered");
                numHam = Convert.ToInt16(Console.ReadLine());

            }
            // Display results
            Console.WriteLine();//not finished
        }
    }
}
