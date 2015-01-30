/*
 * Write a program that reads a string from the console and lists all different words 
 * in the string along with information how many times each word is found.
 */
namespace _22_TextWordsFrequency
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            var wordsFreq = new Dictionary<string, int>();
            
            Console.WriteLine("Enter text for analyzing: ");
            input = Console.ReadLine();

            var words = input.Split(
                new char[] { ',', ' ', '.', '!', '?', ':', ';' }, 
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (wordsFreq.ContainsKey(word))
                    wordsFreq[word] += 1;
                else 
                    wordsFreq.Add(word, 1);
            }

            foreach (var item in wordsFreq)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}
