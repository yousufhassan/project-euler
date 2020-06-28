using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p2_evenFibonacciNumbers
Class: Project Euler
ClassName: Program
Description: By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
Date: May 4, 2020
Notes:
*/

namespace p2_evenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> fibSequence = Fibonacci();
            double sum = 0;

            for (int i = 0; i < fibSequence.Count; i++)
            {
                if (fibSequence[i] % 2 == 0)
                {
                    sum += fibSequence[i];
                }                     
            }

            Console.WriteLine("The answer is: " + sum);
            Console.ReadLine();
        }

        // This method determines the numbers in the Fibonacci sequence, which are less than four million
        // Arguments: None
        public static List<double> Fibonacci()
        {
            List<double> fibSequence = new List<double>();
            fibSequence.Add(1); // first value in fibonacci sequence
            fibSequence.Add(2); // second value in fibonacci sequence

            bool fourMillion = true;

            for (int i = 0; fourMillion; i++) // while the value is less than four million
            {
                if ((fibSequence[i] + fibSequence[i + 1]) <= 4000000) // check to see if the value is less than four million
                {
                    fibSequence.Add(fibSequence[i] + fibSequence[i + 1]);
                }

                else
                {
                    fourMillion = false;
                }
            }

            return fibSequence;
        }
    }
}
