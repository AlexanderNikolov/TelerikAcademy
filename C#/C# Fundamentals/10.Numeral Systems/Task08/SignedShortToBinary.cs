/*
 * Write a program that shows the binary representation of given 16-bit 
 * signed integer number (the C# type short)
 */

namespace TA2014_CSharp_NumralSystems_homework
{
    using System;

    class Task08
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SignedShortToBinary(-125));
        }

        static string SignedShortToBinary(short number)
        {
            if (number < 0)
                return Convert.ToString(number, 2).PadLeft(16, '1'); //take care about negative input
            else
                return Convert.ToString(number, 2);
        }
    }
}