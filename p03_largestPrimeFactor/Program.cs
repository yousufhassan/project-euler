using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p3_largestPrimeFactor
Class: Project Euler
ClassName: Program
Description: What is the largest prime factor of the number 600851475143
Name: Yousuf Hassan
Date: May 4, 2020
Notes:
*/

namespace p3_largestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The answer is: ");
            Console.WriteLine(largestPrimeFactor(600851475143));
        }

        // This method finds the largest prime factor of any number
        // Arguments: double number you are solving for
        public static double largestPrimeFactor(double target)
        {
            double answer = 0;
            bool cont = true;
            bool isPrime = true;

            for (double i = target - 1; i > 1 && cont; i--)
            {
                if ((target % i == 0)) // determines if the number is a factor of the target
                {
                    for (double j = i - 1; j > 1 && isPrime; j--)
                    {
                        if (i % j == 0) // if the number is not a prime number
                        {
                            cont = true;
                            isPrime = false; // causes to break out of loop
                        }

                        else // if the number is a prime number
                        {
                            answer = i;
                            cont = false;
                        }
                    }

                    isPrime = true; // allows program to re-enter in the nested for loop, if needed
                }
            }

            return answer;
        }
    }
}
