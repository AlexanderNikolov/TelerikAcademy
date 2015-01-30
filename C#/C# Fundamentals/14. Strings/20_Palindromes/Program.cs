/*
 * Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe"
 */
namespace _20_Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string text = "ABBA only lamal idiot exe can radar read pop this";
            var collection = text.Split(' ');
            foreach (var item in collection)
            {
                if (item == string.Join("", item.Reverse()))
                {
                    Console.WriteLine(item);                    
                }
            }
        }
    }
}
