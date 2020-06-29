using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p5_smallestMultiple
Class: Project Euler
ClassName: Program
Description: What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
Name: Yousuf Hassan
Date: May 5, 2020
Notes: This is the first way I thought of how to solve it. It might be inefficient or not very modular. Adding a method where the critera is the
       argument can make the program more modular. Then check if the remainder is 0 for all of the numbers up to the criteria, depending on what
       it is.
*/

namespace p5_smallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            for (int i = 20; cont; i++) // starts at 20 because anything below would not satisfy the criteria
            {
                if ((i % 1 == 0) && (i % 2 == 0) && (i % 3 == 0) && (i % 4 == 0) && (i % 5 == 0) && (i % 6 == 0) && (i % 7 == 0) && (i % 8 == 0) &&
                    (i % 9 == 0) && (i % 10 == 0) && (i % 11 == 0) && (i % 12 == 0) && (i % 13 == 0) && (i % 14 == 0) && (i % 15 == 0) &&
                    (i % 16 == 0) && (i % 17 == 0) && (i % 18 == 0) && (i % 19 == 0) && (i % 20 == 0))
                {
                    cont = false; // answer has been found, so break out of the loop
                    Console.WriteLine(i); // output the answer
                }
            }
        }
    }
}
