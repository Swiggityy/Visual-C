using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bankBal;
            double rate;
            int year;
            double startBal;
            const double START_INT = .04;
            const double INT_INCREASE = .02;
            const double LAST_INT = .08;
            int endYear;

            Console.WriteLine("Enter Starting Balance");
            startBal = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("How many years do you want?");
            endYear = Convert.ToInt16(Console.ReadLine());

            for(rate = START_INT; rate <= LAST_INT; rate += INT_INCREASE)
            {
                bankBal = startBal;
                Console.WriteLine("Starting bank balance is {0}", bankBal.ToString("C"));
                Console.WriteLine("Interest Rate: {0}", rate.ToString("P"));

                for(year = 1; year <= endYear; ++year)
                {
                    bankBal = bankBal + bankBal * rate;
                    Console.WriteLine("After year {0}, bank balance is {1}", year, bankBal.ToString("C"));
                }
                Console.ReadLine();
            }
        }
    }
}