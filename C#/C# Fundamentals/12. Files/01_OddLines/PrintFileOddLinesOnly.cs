/*
 * Write a program that reads a text file and prints on the console its odd lines
 */

namespace TA2014_TextFiles_homework
{
    using System;
    using System.Linq;
    using System.IO;

    class ReadFile
    {
        static void Main(string[] args)
        {
            //redirect console input from file
            if (Environment.CurrentDirectory
                           .ToLower()
                           .EndsWith("bin\\debug"))
            {
                Console.SetIn(new StreamReader("test.txt"));
            }

            try
            {
                string input = string.Empty;
                int count = 1;
                do
                {
                    input = Console.ReadLine();

                    if (count % 2 != 0)
                        Console.WriteLine(input);
                    count++;

                } while (input != null);
            }
            catch (FileNotFoundException)
            {
                throw new ArgumentException("File not found!");
            }
        }
    }
}
