/*
 * Write a program that deletes from a text file all words that start with 
 * the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.
 */

namespace _11_RemoveWordsPrefix
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.IO;

    class p11
    {
        static void Main(string[] args)
        {
            var input = new StreamReader("../../sample.txt");
            var output = new StreamWriter("../../edited.txt");

            using (input)
            using (output)
            {
                while (!input.EndOfStream)
                {
                    output.WriteLine(Regex.Replace(input.ReadLine(), @"\btest\w", string.Empty));
                }
            }
        }
    }
}