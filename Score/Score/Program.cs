using System;
//Created by: Chris Nguyen
namespace Score
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables and Constants
            double student1, student2, student3;
            double average;
            const int NUM_STUDENTS = 3;

            Console.WriteLine("Enter score for student 1");
            student1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter score for student 2");
            student2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter score for student 3");
            student3 = Convert.ToDouble(Console.ReadLine());
            average = (student1 + student2 + student3) / NUM_STUDENTS;

            //Display to user
            Console.WriteLine("The scores for the three students were {0},{1},{2}. Their average was {3}", student1,student2,student3, average);
        }
    }
}
