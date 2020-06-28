using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p1_multiples_3_and_5
Class: Project Euler
ClassName: Program
Description: This program finds the sum of all the multiples of 3 or 5 below 1000.
Date: May 4, 2020
Notes:
*/

namespace p1_multiples_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0)) // if the number is a multiple of 3 or 5
                {
                    sum += i; // add it to the sum
                }
            }

            Console.WriteLine("The sum is: " + sum);
            Console.ReadLine();
        }
    }
}
