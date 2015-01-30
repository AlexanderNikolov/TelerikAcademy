/*
 * Write a program that reads a string, reverses it and prints the result 
 * at the console. Example: 
 *          "sample"  "elpmas"
 */
namespace TA2014_Strings_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input random string: ");
            var input = Console.ReadLine();
            var reversed = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine("Result after string reverse: {0}", reversed);
        }
    }
}
