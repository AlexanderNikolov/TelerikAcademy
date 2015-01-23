/*
 * Write a program that replaces all occurrences of the substring "start" 
 * with the substring "finish" in a text file. 
 * Ensure it will work with large files (e.g. 100 MB)
 */

namespace TA2014_TextFiles_homework
{
    using System;
    using System.Linq;
    using System.Text;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string pathIn = "input.txt";
            string pathOut = "output.txt";

            ReplaceStringInFile(pathIn, pathOut);
            ReadFromFile(pathOut);
        }

        private static void ReplaceStringInFile(string pathIN, string pathOUT)
        {
            var data = new StringBuilder();
            using (var reader = new StreamReader(pathIN))
            {
                using (var writer = new StreamWriter(pathOUT))
                {
                    while (!reader.EndOfStream)
                    {
                        data.AppendLine(reader.ReadLine().Replace("start", "finish")); //much better then IndexOff + if_else
                        writer.WriteLine(data.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// helper method for test visualization
        /// </summary>
        /// <param name="path"></param>
        private static void ReadFromFile(string path)
        {
            using (StreamReader stream = new StreamReader(path))
            {
                while (!stream.EndOfStream)
                    Console.WriteLine(stream.ReadLine());
            }
        }
    }
}
