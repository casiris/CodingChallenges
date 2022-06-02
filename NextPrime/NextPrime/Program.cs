//Given an integer, create a function that returns the next prime. If the number is prime, return the number itself.

//Examples:
//NextPrime(12) ➞ 13

//NextPrime(24) ➞ 29

//NextPrime(11) ➞ 11
//// 11 is a prime, so we return the number itself. 

using System;

namespace NextPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testNumbers = { 1, 2, 3, 4, 5, 6, 7 , 11, 12, 24};

            foreach (int testNumber in testNumbers)
            {
                Console.WriteLine("{0} -> {1}", testNumber, NextPrime(testNumber));
            }
        }

        private static bool IsPrime(int input)
        {
            if (input <= 1)
            {
                return false;
            }
            if (input <= 3)
            {
                return true;
            }

            // somehow this is efficient, i don't really understand it
            if (input % 2 == 0 || input % 3 == 0)
            {
                return false;
            }

            // more math stuff, also, checking if i * i < input is the same as i < sqrt(input), or something like that
            for (int i = 5; i * i <= input; i = i + 6)
            {
                if (input % i == 0 || input % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int NextPrime(int input)
        {
            if (input < 2)
            {
                return 2;
            }

            bool primeFound = false;
            int numberToCheck = input;

            while (primeFound == false)
            {
                numberToCheck++;

                if (IsPrime(numberToCheck))
                {
                    primeFound = true;
                }
            }
            return numberToCheck;
        }
    }
}