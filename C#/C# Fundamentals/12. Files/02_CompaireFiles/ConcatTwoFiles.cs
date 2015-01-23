//Write a program that concatenates two text files into another text file

namespace TA2014_TextFiles_homework
{
    using System;
    using System.Linq;
    using System.IO;

    class ConcatFiles
    {
        static void Main(string[] args)
        {
            string pathIn = "input.txt";
            string pathOut = "output.txt";

            ClearFile(pathOut);
            WriteToFile(pathIn, pathOut);
            WriteToFile(pathIn, pathOut); //write same file again
            
            ReadFromFile(pathOut); //output result
        }

        static void WriteToFile(string pathIn, string pathOut)
        {
            using (StreamWriter output = new StreamWriter(pathOut, true))
            {
                using (StreamReader stream = new StreamReader(pathIn))
                {
                    while (!stream.EndOfStream)
                        output.WriteLine(stream.ReadLine());
                }
            }
        }

        static void ClearFile(string path)
        {
            using (var stream = new FileStream(path, FileMode.Truncate))
            {
                using (var writer = new StreamWriter(stream))
                {
                    string clear = null;
                    writer.Write(clear);
                }
            }
        }

        //TODO: modified method to fill data in array
        static void ReadFromFile(string path)
        {
            using (StreamReader stream = new StreamReader(path))
            {
                while (!stream.EndOfStream)
                    Console.WriteLine(stream.ReadLine());
            }
        }
    }
}
