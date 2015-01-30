/*
 * Write a program that reads a string from the console and prints all different 
 * letters in the string along with information how many times each letter is found. 
 */
namespace _20_LettersFrequency
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter random string for analyzing: ");
            string input = Console.ReadLine();
            var letters = input.ToCharArray();
            var lettersFreq = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (char.IsLetter(letter) && !lettersFreq.ContainsKey(letter))
                {
                    lettersFreq.Add(letter, 1);
                }
                if (char.IsLetter(letter) && lettersFreq.ContainsKey(letter))
                {
                    lettersFreq[letter] += 1; 
                }
            }

            foreach (var item in lettersFreq)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}
