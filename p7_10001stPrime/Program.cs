using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p7_10001stPrime
Class: Project Euler
ClassName: Program
Description: What is the 10001st prime number?
Name: Yousuf Hassan
Date: May 6, 2020
Notes: There is probably a much more efficient way to do this, but this was my first solution.
*/

namespace p7_10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The answer is: " + PrimeNumbers(10001));
        }

        // This method calculates all the prime numbers to a requested one, and then outputs the requested prime number
        // Arguments: integer to get the nth prime number
        public static double PrimeNumbers(int primeNum)
        {
            bool cont = true;
            bool isPrime = true;
            int factors = 0;
            int answer = 0;
            List<double> primeNums = new List<double>();
            primeNums.Add(2);

            for (int i = 2; cont; i++)
            {
                for (int j = 1; j <= i && isPrime; j++)
                {
                    if (i % j == 0) // if the number is a factor
                    {
                        factors++;
                    }

                    if (factors > 2) // if the number is not a prime number
                    {
                        isPrime = false; // exits nested for loop
                    }
                }

                if (factors == 2) // if the number is a prime number
                {
                    primeNums.Add(i); // add it to the list
                }

                if (primeNums.Count() == primeNum + 1) // if the list reaches the requested nth prime number
                {
                    cont = false;
                    answer = i;
                }

                isPrime = true; // allows re-entry into nested for loop
                factors = 0; // reset factor counter for next number
            }

            return answer;
        }
    }
}
