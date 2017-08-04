using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program2
    {
        static void Main()
        {
            int x = 20;
            int y = 3;

            Console.WriteLine("20/3 = {0}", x / y); //6 because it's integer division
            Console.WriteLine("20/3 = {0}", 1.0 * x / y); //6.6 because it's NOT integer division
            Console.WriteLine("remainder = {0}", x % y);

            double xx = 20.1;
            double yy = 3.1;

            Console.WriteLine("20/3 = {0}", xx / yy); //6.6 because it's NOT integer division
            Console.WriteLine("remainder = {0}", xx % yy);
            Console.WriteLine("remainder = {0}", 5.0 % 2.2);

        }
    }
}
