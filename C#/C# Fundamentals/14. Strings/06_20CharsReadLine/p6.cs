/*
 * Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should be 
 * filled with '*'. Print the result string into the console.
 */

namespace _06_20CharsReadLine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().PadRight(20, '*');

            input = input.Remove(20, (input.Length-20));
            Console.WriteLine("{0} {1}", input, input.Length);
        }
    }
}
