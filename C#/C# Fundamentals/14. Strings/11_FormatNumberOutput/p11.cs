/*
 * Write a program that reads a number and prints it as a decimal number, 
 * hexadecimal number, percentage and in scientific notation. 
 * Format the output aligned right in 15 symbols.
 */
namespace _11_FormatNumberOutput
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input random number: ");
            var input = decimal.Parse(Console.ReadLine());

            Console.WriteLine("formated:");
            Console.WriteLine("{0, 15}", input);
            Console.WriteLine("{0, 15:X}", (int)input);
            Console.WriteLine("{0, 15:P}", input);
            Console.WriteLine("{0, 15:E}", input);
        }
    }
}
