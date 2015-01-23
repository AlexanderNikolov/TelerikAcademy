/*
 * Write a program that reads a text file containing a list of strings, 
 * sorts them and saves them to another text file. 
 * Example:
 *      Ivan			George
 *      Peter			Ivan
 *      Maria			Maria
 *      George			Peter
 */

namespace TA2014_TextFiles_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string pathIn = "input.txt";
            string pathOut = "output.txt";
            var names = new List<string>();

            names = ReadWriteToFile(null, pathIn);
            names.Sort();
            ReadWriteToFile(names, pathOut);

            //for debug purposes only
            ReadFromFile(pathOut);
        }

        private static List<string> ReadWriteToFile(List<string> data, string path)
        {
            var result = new List<string>();
            if (data==null)
            {
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                        result.Add(reader.ReadLine());
                }
            }
            else
            {
                using (var writer = new StreamWriter(path))
                {
                    foreach (var item in data)
                        writer.WriteLine(item);
                }
            }

            return result;
        }

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
