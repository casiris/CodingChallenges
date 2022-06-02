using System;
using System.Text.RegularExpressions;

namespace ValidHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tests = { "#CD5C5C", "#EAECEE", "#eaecee", "#CD5C58C", "#CD5C5Z", "#CD5C&C", "CD5C5C"};

            foreach (string test in tests)
            {
                Console.WriteLine("{0} -> {1}", test, IsValidHexCode(test));
            }
        }

        public static bool IsValidHexCode(string inputString)
        {
            if (inputString == null)
            {
                return false;
            }

            // regular expression to check if string starts with a hash symbol, has 6 letters/numbers a-f or 0-9, or 3 letters/numbers in the case of a short form hex code
            Regex expression = new Regex("^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$");

            if (expression.IsMatch(inputString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
