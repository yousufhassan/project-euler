using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p9_specialPythagoreanTriplet
Class: Project Euler
ClassName: Program
Description: A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

             a2 + b2 = c2
             For example, 32 + 42 = 9 + 16 = 25 = 52.

             There exists exactly one Pythagorean triplet for which a + b + c = 1000.
             Find the product abc.
             
Name: Yousuf Hassan
Date: May 28, 2020
Notes: At first I was trying a brute-force solution but to no avail. Then I took a break and researched about pythagorean triplets and
       how to construct them. When I learned how to construct them, I wrote the code but for my initial i and j values, I had to do guess and check.
       My next step is to find a way where they computer will automatically test different i and j values without my external input.
       Source: https://www.mathsisfun.com/numbers/pythagorean-triples.html
*/

namespace p9_specialPythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            int origIVal = 2;
            int i = origIVal;
            int j = i - 1;

            for (i = origIVal; cont; i++)
            {

                double a = Math.Pow(i, 2) - Math.Pow(j, 2);
                double b = 2 * i * j;
                double c = Math.Pow(i, 2) + Math.Pow(j, 2);
                double sum = a + b + c;

                Console.WriteLine("The current i and j values are " + i + " and " + j);
                Console.WriteLine("For the numbers " + a + ", " + b + ", " + c + " the sum is " + sum);
                Console.WriteLine();
                if (sum == 1000)
                {
                    Console.WriteLine("The numbers are: " + a + ", " + b + ", " + c);
                    Console.WriteLine("The product of the numbers is: " + a * b * c);
                    cont = false;
                }

                else if (sum > 1000)
                {
                    i = origIVal++;
                    j = i - 1;
                }
            }

            Console.ReadLine();
        }

        //// Method that checks if the three numbers are a pythagorean triplet
        //// Arugements: three doubles
        //public static bool IsPythagoreanTriplet(double a, double b, double c)
        //{
        //    double leftSide = Math.Pow(a, 2) + Math.Pow(b, 2);
        //    double rightSide = Math.Pow(c, 2);
        //    if (leftSide == rightSide)
        //    {
        //        return true;
        //    }

        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
