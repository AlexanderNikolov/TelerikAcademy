/*
 * Write a program that reads a text file and inserts line numbers in front 
 * of each of its lines. The result should be written to another text file
 */

namespace TA2014_TextFiles_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    class AddNumberingToFileLines
    {
        static void Main(string[] args)
        {
            var inputPath = "input.txt";
            var outputPath = "output.txt";

            FileReadWrite(inputPath, outputPath);
            FileToConsole(outputPath);
        }

        static void FileReadWrite(string pathIn, string pathOut)
        {
            using (var reader = new StreamReader(pathIn))
            {
                using (var writer = new StreamWriter(pathOut))
                {
                    var linesHeader = 1;
                    while (!reader.EndOfStream)
                    {
                        writer.Write(linesHeader++);
                        writer.Write(". ");
                        writer.WriteLine(reader.ReadLine());
                    }       
                }
            }
        }

        static void FileToConsole(string path)
        {
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
