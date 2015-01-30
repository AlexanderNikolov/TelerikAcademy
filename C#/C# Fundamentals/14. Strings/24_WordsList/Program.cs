/*
 * Write a program that reads a list of words, separated by spaces and prints 
 * the list in an alphabetical order.
 */
namespace _24_WordsList
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string text = "word car year elephant boy";
            var words = text.Split(' ');
            var sortedWords = from word in words
                              orderby word[0] ascending
                              select word;

            Console.WriteLine(string.Join(" ", sortedWords));
        }
    }
}
