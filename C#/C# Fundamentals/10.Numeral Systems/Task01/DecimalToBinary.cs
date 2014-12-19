/*
 * Write a program to convert decimal numbers to their binary representation
 */

namespace TA2014_CSharp_NumralSystems_homework
{
    using System;

    class Task01
    {
        static void Main(string[] args)
        {
            long number;

            Console.WriteLine("Free converting from decimal to binary! \nInput integer number to convert ");
            string input = Console.ReadLine();

            if (long.TryParse(input, out number))
            {
                string output = DecimalToBinary(number);
                Console.WriteLine("{0} \nThank you for using our services! Have a nice day!", output);
            }
            else
                throw new ArgumentException();
        }

        static string DecimalToBinary(long number)
        {
            if (number < 0)
                return Convert.ToString(number, 2).PadLeft(32, '1');
            else
                return Convert.ToString(number, 2);
        }
    }
}