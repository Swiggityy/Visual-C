using System;

namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PINC = .02;
            double syear = 2000;
            int population = 795000, year;

            Console.WriteLine("Enter current year");
            year = Convert.ToInt16(Console.ReadLine());

            while (year + 1 != syear)
            {
                Console.WriteLine("The population for {0} was {1}", syear, population);
                population = (int)(population * (1 + PINC));
                syear = syear + 1;
            }
            Console.ReadLine();
        }
    }
}