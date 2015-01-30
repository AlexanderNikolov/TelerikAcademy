/*
 * Write a program that finds how many times a substring is contained in a given text 
 * (perform case insensitive search).
 */

namespace _04_SubstringMatchingCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var example = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            var target = "in";

            Console.WriteLine(SubstringFrequencyCounter(example, target));

            //regex
            //Console.WriteLine(Regex.Matches(text, target, RegexOptions.IgnoreCase).Count);
        }

        private static int SubstringFrequencyCounter(string text, string substring)
        {
            string[] words = text.Split(new char[] {' ', ',', '.', ';', ':', '!', '?', '*'}, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            foreach (var word in words)
            {
                if (word.IndexOf(substring, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    count++;
                if (word.IndexOf(substring, StringComparison.CurrentCultureIgnoreCase) !=
                    word.LastIndexOf(substring, StringComparison.CurrentCultureIgnoreCase))
                    count++;
            }

            return count;
        }
    }
}
