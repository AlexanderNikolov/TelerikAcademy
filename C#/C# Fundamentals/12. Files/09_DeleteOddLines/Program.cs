/*
 * Write a program that deletes from given text file all odd lines. 
 * The result should be in the same file.
 */

namespace _09_DeleteOddLines
{
    using System;
    using System.Linq;
    using System.Text;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string path = "input.txt";

            DeleteOddLinesInFile(path);
            TextFilePrinter(path);
        }

        private static void DeleteOddLinesInFile(string path)
        {
            var data = new StringBuilder();
            using (var reader = new StreamReader(path))
            {
                int count = 1;
                while (!reader.EndOfStream)
                {
                    if (count % 2 == 0)
                    {
                        data.AppendLine(reader.ReadLine());
                    }
                    else
                    {
                        reader.ReadLine();
                    }

                    count++;
                }
            }

            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(data.ToString());
            }
        }

        /// <summary>
        /// helper method for test visualization
        /// </summary>
        /// <param name="path"></param>
        private static void TextFilePrinter(string path)
        {
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                    Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
