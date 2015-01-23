/*
 * Write a program that compares two text files line by line and prints 
 * the number of lines that are the same and the number of lines that 
 * are different. Assume the files have equal number of lines.
 */

namespace TA2014_TextFiles_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    class FilesComparer
    {
        static void Main(string[] args)
        {
            string inputPath = "input.txt";
            string inputPath2 = "input2.txt";

            ComparesFiles(inputPath, inputPath2);
        }

        static void ComparesFiles(string path1, string path2)
        {
            using (StreamReader input1 = new StreamReader(path1))
            {
                using (StreamReader input2 = new StreamReader(path2))
                {
                    int countEqual = 0, countOdd = 0;

                    while (!input1.EndOfStream)
                    {
                        if (input1.ReadLine() == input2.ReadLine())
                            countEqual++;
                        else
                            countOdd++;
                    }

                    Console.WriteLine("Equals lines = {0}, odd lines = {1}", countEqual, countOdd);
                }
            }
        }
    }
}
