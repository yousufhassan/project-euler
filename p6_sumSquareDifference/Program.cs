using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p6_sumSquareDifference
Class: Project Euler
ClassName: Program
Description: Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
Name: Yousuf Hassan
Date: May 5, 2020
Notes: There is probably a way to do it recursively, but I didn't do it that way. A possible variation or next step can be to solve this problem
       using recursive methods.
*/

namespace p6_sumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The answer is: " + (SquareOfSum(100) - SumOfSquares(100)));
            Console.ReadLine();
        }

        // This method calculates the sum of the squares of the first n natural numbers
        // Arguments: integer to sum up to
        public static double SumOfSquares(int num) // sqaures each number first, then sums it up
        {
            double sum = 0;

            for (double i = 1; i <= num; i++)
            {
                sum += Math.Pow(i, 2);
            }

            return sum;
        }

        // This method calculates the square of the sum of the first n natural numbers
        // Arguments: integer to sum up to
        public static double SquareOfSum(int num) // sums all of the numebrs, then squares it
        {
            double sum = 0;

            for (double i = 1; i <= num; i++)
            {
                sum += i;
            }

            return Math.Pow(sum, 2);
        }
    }
}
