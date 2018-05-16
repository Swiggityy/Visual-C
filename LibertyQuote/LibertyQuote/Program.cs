using System;
//created by: Chris Nguyen
namespace LibertyQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            double hr, mile;
            double total;
            const int BASE_PAY = 300;

            Console.WriteLine("Enter hours worked");
            hr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter miles traveled");
            mile = Convert.ToDouble(Console.ReadLine());

            total = BASE_PAY + (hr * 150) + (mile * 3);

            Console.WriteLine("Your total cost is " + total);
            Console.ReadLine();
        }
    }
}
