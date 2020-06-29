using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p10_summationOfPrimes
Class: Project Euler
ClassName: Program
Description: The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
             Find the sum of all the primes below two million.
Name: Yousuf Hassan
Date: June 28, 2020
Last Revised: June 28, 2020
Notes:
*/

namespace p10_summationOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum of the primes is: " + GetSum(GetPrimes(2000000)));
            Console.ReadLine();
        }

        // Method to get all the prime numbers up to a certain number
        // Arguments: value to get prime numbers up to
        public static List<double> GetPrimes(int maxVal)
        {
            List<double> primes = new List<double> { 2, 3 };
            bool cont = true;

            for (double i = 4; i < maxVal; i++) // loop for prime number
            {
                for (int j = 1; j < i && cont; j++) // loop for integer that gets any possible prime number
                {
                    if (i % ((6 * j) - 1) == 0 || i % ((6 * j) + 1) == 0)
                    {
                        for (int k = 2; k < i && cont; k++) // loop to check for any factors, if the number is composite
                        {
                            if (i % k == 0)
                            {
                                cont = false;
                            }

                            else if (k == i - 1)
                            {
                                Console.WriteLine(i);
                                primes.Add(i);
                            }
                        }
                    }

                    else if (j == i - 1)
                    {
                        cont = false;
                    }
                }

                cont = true;
            }

            return primes;
        }

        // Method to get the sum of all the integers in a list
        // Arguments: list of integers
        public static double GetSum(List<double> list)
        {
            double sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }
    }
}


            //for (int i = 3; i<maxVal; i++)
            //{
            //    for (int j = 2; j<i && cont; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            cont = false;
            //        }

            //        else if (i % j != 0 && j == i - 1)
            //        {
            //            primes.Add(i);
            //        }
            //    }

            //    cont = true;
            //}