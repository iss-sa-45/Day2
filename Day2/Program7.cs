using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program7
    {
        static void Main()
        {
            //getting the input
            Console.Write("Enter the number grade: ");
            double noGrade = Double.Parse(Console.ReadLine());

            //check the input 
            string grade="";
            //if between 85-100 A+
            if (noGrade > 85 && noGrade <= 100)
            {
                grade = "A+";
            }
            //80-85 A
            else if (noGrade > 80 && noGrade <= 85)
            {
                grade = "A";
            }
            //75-80 A-
            else if (noGrade > 75 && noGrade <= 80)
            {
                grade = "A-";
            }
            //70-75 B+
            else if (noGrade > 70 && noGrade <= 75)
            {
                grade = "B+";
            } 
            //65-70 B
            else if (noGrade > 65 && noGrade <= 70)
            {
                grade = "B";
            } 
            //others, less than B
            else if (noGrade <= 65)
            {
                grade = "Less than B";
            }
            else
            {
                grade = "undefined";
            }

            //print out the grade
            Console.WriteLine("Your grade is {0}", grade);
        }
    }
}
