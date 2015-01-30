/*
 * Write a program that extracts from a given text all sentences containing given word.
 */
namespace _08_ExtractSentences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string selector = "in";

            var collection = SentenceSelector(text, selector);
            foreach (var sentence in collection)
            {
                Console.WriteLine(sentence);
            }
        }

        private static List<string> SentenceSelector(string text, string selector)
        {
            var result = new List<string>();
            string[] lines = text.Split('.');
            foreach (var line in lines)
            {
                string[] words = line.Split(' ');
                if (words.Contains(selector))
                {
                    result.Add(line.Trim());
                }
            }

            return result;
        }
    }
}
