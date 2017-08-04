using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program8
    {
        static void Main()
        {
            //0 - Sunday
            //1 - Monday
            //2 - Tuesday
            //6 - Saturday

            Console.Write("Enter a number: (0-6) ");
            int no = Int32.Parse(Console.ReadLine());

            string day = "";
            //if (no==0)
            //{
            //    day = "Sunday";
            //} else if (no==1)
            //{
            //    day = "Monday";
            //} else if (no ==2)
            //{
            //    day = "Tuesday";
            //}

            switch (no)
            {
                case -1:
                case -2:
                case 0:
                    day = "Sunday";
                    break;
                case -3:
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                default:
                    day = "Not a day";
                    break;
            }

            Console.WriteLine(day);

        }
    }
}
