/*
 * Write a program to convert decimal numbers to their hexadecimal representation
 */

namespace TA2014_CSharp_NumralSystems_homework
{
    using System;

    class Task03
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input integer number to convert ");
            string input = Console.ReadLine();
            long number;

            if (long.TryParse(input, out number))
            {
                string output = DecimalToHexCalc(number);
                Console.WriteLine(output);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        static string DecimalToHexCalc(long number)
        {
            string result;

            if (number < 0)
            {
                result = Convert.ToString(number, 2).PadLeft(64, '1');
            }
            else
            {
                result = Convert.ToString(number, 2).PadLeft(64, '0');
            }

            result = Switch(result).TrimStart(new Char[] { '0' });

            return result;
        }

        static string Switch(string input)
        {
            string result = null;

            for (int i = 0; i < input.Length; i += 4)
            {
                string current = input.Substring(i, 4);

                switch (current)
                {
                    case "0000": result += "0"; break;
                    case "0001": result += "1"; break;
                    case "0010": result += "2"; break;
                    case "0011": result += "3"; break;
                    case "0100": result += "4"; break;
                    case "0101": result += "5"; break;
                    case "0110": result += "6"; break;
                    case "0111": result += "7"; break;
                    case "1000": result += "8"; break;
                    case "1001": result += "9"; break;
                    case "1010": result += "A"; break;
                    case "1011": result += "B"; break;
                    case "1100": result += "C"; break;
                    case "1101": result += "D"; break;
                    case "1110": result += "E"; break;
                    case "1111": result += "F"; break;

                    default: break;
                }
            }

            return result;
        }
    }
}