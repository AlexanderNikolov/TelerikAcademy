/*
 * Write a program to convert binary numbers to their decimal representation
 */

namespace TA2014_CSharp_NumralSystems_homework
{
    using System;

    class Task02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input binary number for converting ");
            string input = Console.ReadLine();

            Console.WriteLine(BinaryToDecimal(input));
        }

        static long BinaryToDecimal(string input)
        {
            long result = 0;
            int count = 0;
            long number;

            if (long.TryParse(input, out number))
            {
                while (number > 0)
                {
                    result += (number % 10) * (1L << count);
                    count++;
                    number /= 10;
                }

                return result;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}