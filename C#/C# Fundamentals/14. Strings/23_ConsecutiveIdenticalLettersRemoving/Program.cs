/*
 * Write a program that reads a string from the console and replaces all series 
 * of consecutive identical letters with a single one. 
 *      Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
 */
namespace _22_ConsecutiveIdenticalLettersRemoving
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var result = new StringBuilder();
            string text = "aaaaabbbbbcdddeeeedssaa";

            var collection = text.ToCharArray();
            result.Append(text[0]);
            for (int i = 1; i < collection.Length; i++)
            {
                if (collection[i] != collection[i - 1])
                    result.Append(collection[i]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
