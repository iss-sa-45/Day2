using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program3
    {
        static void Main()
        {
            int a = 1;

            a++;
            a--;
            ++a;
            --a;
            Console.WriteLine(a);

            a = 1;
            Console.WriteLine(a++); // write a, then inc a

            a = 1;
            Console.WriteLine(++a); // inc a, then write a

            //round example
            double x = 3.2934723;

            Console.WriteLine(Math.Round(x, 2));
            Console.WriteLine(Math.Round(x, 1));
            Console.WriteLine(Math.Round(x, 0));
            Console.WriteLine(Math.Round(x, 5));

            Console.WriteLine(Math.Floor(x));

            Console.WriteLine(Math.Max(1, 2));

        }
    }
}
