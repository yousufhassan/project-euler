using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Namespace: p4_largestPalindromeProduct
Class: Project Euler
ClassName: Program
Description: Find the largest palindrome made from the product of two 3-digit numbers
Name: Yousuf Hassan
Date: May 5, 2020
Notes: From this problem, I learned how to parse an integer where each digit is an individual character in a char array. Also, how to find
       the max value in a set of numbers (whether it is in a list or an array).
*/

namespace p4_largestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The answer is: " + LargestPalindrome());
            Console.ReadLine();
        }

        // This method finds the largest palindrome made from the product of two 3-digit numbers
        // Arguments: None
        public static int LargestPalindrome()
        {
            bool cont = true;
            List<int> palindromes = new List<int>(); // list of all palindromes

            for (int i = 999; i > 0 && cont; i--) // first number to multiply
            {
                for (int j = 999; j > 0 && cont; j--) // second number to multiply
                {
                    int product = i * j;
                    char[] arr = product.ToString().ToCharArray(); // converts the integer product to a char array

                    if (IsPalindrome(arr)) // if the number is a palindrome
                    {
                        palindromes.Add(product); // add it to the list
                    }
                }
            }

            int max = palindromes.Max(); // finds the greatest value in the list

            return max;
        }

        // This method checks if the integer is a palindrome
        // Arguments: char array
        public static bool IsPalindrome(char[] arr)
        {
            bool isPalindrome = false;
            bool cont = true;
            int end = arr.Length - 1; // index from the end of the array

            for (int front = 0; front < arr.Length && cont; front++)
            {
                if (arr[front] == arr[end]) // if front index value is same as end index value
                {
                    isPalindrome = true;
                    end--;
                }

                else // if at any point the values are not equal, then break out of the loop and the integer is not a palindrome
                {
                    isPalindrome = false;
                    cont = false;
                }
            }

            return isPalindrome;
        }

    }
}
