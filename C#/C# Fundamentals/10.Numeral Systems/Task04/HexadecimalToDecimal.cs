/*
 * Write a program to convert hexadecimal numbers to their decimal representation
 */

namespace TA2014_CSharp_NumralSystems_homework
{
    using System;

    class Task04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input hexdecimal number for converting ");
            string input = Console.ReadLine().ToUpper();

            Console.WriteLine(ConvertHexToDecimal(input));
        }

        public static long ConvertHexToDecimal(string input)
        {
            long result = 0;
            int length = input.Length;

            for (int i = 0, j = length; i < length; i++, j--)
            {
                int currentPosition = HexSwitch(input.Substring(i, 1));
                result += currentPosition * HexPower(j);
            }
            return result;
        }

        public static int HexSwitch(string input)
        {
            switch (input)
            {
                case "0": return 0;
                case "1": return 1;
                case "2": return 2;
                case "3": return 3;
                case "4": return 4;
                case "5": return 5;
                case "6": return 6;
                case "7": return 7;
                case "8": return 8;
                case "9": return 9;
                case "A": return 10;
                case "B": return 11;
                case "C": return 12;
                case "D": return 13;
                case "E": return 14;
                case "F": return 15;
                default: throw new ArgumentException();
            }
        }

        public static long HexPower(int power)
        {
            long result = 1;

            for (int i = 0; i < power - 1; i++)
                result *= 16;

            return result;
        }
    }
}