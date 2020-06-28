﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p8_largestProductInASeries
Class: Project Euler
ClassName: Program
Description: Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?

             73167176531330624919225119674426574742355349194934
             96983520312774506326239578318016984801869478851843
             85861560789112949495459501737958331952853208805511
             12540698747158523863050715693290963295227443043557
             66896648950445244523161731856403098711121722383113
             62229893423380308135336276614282806444486645238749
             30358907296290491560440772390713810515859307960866
             70172427121883998797908792274921901699720888093776
             65727333001053367881220235421809751254540594752243
             52584907711670556013604839586446706324415722155397
             53697817977846174064955149290862569321978468622482
             83972241375657056057490261407972968652414535100474
             82166370484403199890008895243450658541227588666881
             16427171479924442928230863465674813919123162824586
             17866458359124566529476545682848912883142607690042
             24219022671055626321111109370544217506941658960408
             07198403850962455444362981230987879927244284909188
             84580156166097919133875499200524063689912560717606
             05886116467109405077541002256983155200055935729725
             71636269561882670428252483600823257530420752963450
             
Name: Yousuf Hassan
Date: May 7, 2020
Notes: This seemed very hard to solve first but once I had the general idea in my mind, the only obstacles were to find some new programming
       "conventions"/"concepts" to help me complete my solution. I had to learn how to convert a string into char array, where each element
       is an individual character in the string - this is where I used the .ToCharArray() method. However, we were dealing with numbers in this 
       problem, so I had to convert each char element into its integer value - this is where I used the Char.GetNumericValue() method.
       Other similar char to int conversions would not give me the correct numerical value, but this method did the trick!

       This is the first time I had a for loop in which the initial 'i' value increased after each COMPLETE ITERATION, as well as the
       limit/restriction. I had to think a solution to this dilemma quite a bit, but got it after a bit of brainstorming different approaches!
*/

namespace p8_largestProductInASeries
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = "73167176531330624919225119674426574742355349194934" +
                            "96983520312774506326239578318016984801869478851843" +
                            "85861560789112949495459501737958331952853208805511" +
                            "12540698747158523863050715693290963295227443043557" +
                            "66896648950445244523161731856403098711121722383113" +
                            "62229893423380308135336276614282806444486645238749" +
                            "30358907296290491560440772390713810515859307960866" +
                            "70172427121883998797908792274921901699720888093776" +
                            "65727333001053367881220235421809751254540594752243" +
                            "52584907711670556013604839586446706324415722155397" +
                            "53697817977846174064955149290862569321978468622482" +
                            "83972241375657056057490261407972968652414535100474" +
                            "82166370484403199890008895243450658541227588666881" +
                            "16427171479924442928230863465674813919123162824586" +
                            "17866458359124566529476545682848912883142607690042" +
                            "24219022671055626321111109370544217506941658960408" +
                            "07198403850962455444362981230987879927244284909188" +
                            "84580156166097919133875499200524063689912560717606" +
                            "05886116467109405077541002256983155200055935729725" +
                            "71636269561882670428252483600823257530420752963450";

            Console.WriteLine("The answer is: " + LargestProduct(series));
        }

        public static double LargestProduct(string series)
        {
            double productVal = 1;
            int limit = 12; // index value of the last digit to multiply
            char[] charSeries = series.ToCharArray();
            List<double> products = new List<double>(); // list to store the products

            while (limit != 1000)
            {
                for (int i = limit - 12; i <= limit; i++) // loops through 13 digits of the number and gets the product
                {
                    productVal *= Char.GetNumericValue(charSeries[i]); // convert char to int calculate the product of the 13 digits
                }

                products.Add(productVal); // add the current product to the list of all products
                productVal = 1; // reset the product value
                limit++; // moves up one digit (from the beginning and the end) in the series of numbers
            }

            return products.Max(); // return the max product in the list of products
        }
    }
}
