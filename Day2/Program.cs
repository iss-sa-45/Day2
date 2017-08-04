using System;

namespace Day2
{
    class Quiz
    {
        static void Main()
        {
            Console.Write("Please enter the length in cm: ");
            //string input = Console.ReadLine();
            //double length = Convert.ToDouble(input);

            double length = Convert.ToDouble(Console.ReadLine());

            double lengthInInch = length / 2.54;
            Console.WriteLine("{0:0.000}",lengthInInch);
        }
    }
}
