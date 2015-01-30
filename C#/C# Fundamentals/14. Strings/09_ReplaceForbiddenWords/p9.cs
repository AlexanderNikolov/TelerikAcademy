/*
 * We are given a string containing a list of forbidden words and a text containing 
 * some of these words. Write a program that replaces the forbidden words with asterisks.
 */
namespace _09_ReplaceForbiddenWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string example = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string forbiddenWords = "PHP, CLR, Microsoft";

            example = WordReplacementProcessor(example, forbiddenWords);
            Console.WriteLine(example);

        }

        private static string WordReplacementProcessor(string text, string blacklisted)
        {
            var collection = blacklisted.Split(
                new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries
            );
            
            foreach (var word in collection)
            {
                text = Regex.Replace(text, word, '*'.ToString().PadRight(word.Length, '*'));
            }

            return text;
        }
    }
}
