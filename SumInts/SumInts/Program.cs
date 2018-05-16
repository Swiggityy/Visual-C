using System;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 999;
            double sum = 0, input = 0; 

            Console.WriteLine("enter a number");
            input = Convert.ToDouble(Console.ReadLine());

            while(input != MAX)
            {
                sum = input + sum;
                Console.WriteLine("enter a number");
                input = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Your total is {0}", sum);
            Console.ReadLine();
            
        }
    }
}
