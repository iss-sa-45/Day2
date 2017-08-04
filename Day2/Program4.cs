using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program4
    {
        static void Main()
        {
            Console.Write("Please enter a number below 10: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number < 10)
            {
                Console.WriteLine("Very good. You can follow instruction.");
                Console.WriteLine("**************************************");
            } else
            {
                Console.WriteLine("You cannot follow instruction.");
            }

            //not very safe
            if (number < 10)
                Console.WriteLine("Very good. You can follow instruction.");
            else
                Console.WriteLine("You cannot follow instruction.");

        }
    }
}
