/*
 * Write a program to convert from any numeral system of given base s 
 * to any other numeral system of base d (2 ≤ s, d ≤  16)
 */

namespace TA2014_CSharp_NumralSystems_homework
{
    using System;

    class Task07
    {
        static void Main(string[] args)
        {
            int input = 1010;
            Console.WriteLine("{0} \n{1}\n", input, AnyBaseConvertSwitch(input.ToString(), 2, 16));
        }

        static char NumberToChar(int number)
        {
            if (number >= 10)
                return (char)('A' + number - 10);
            else
                return (char)('0' + number);
        }

        static int StringToNumber(string input, int index)
        {
            if (input[index] >= 'A')
                return input[index] - 'A' + 10;
            else
                return input[index] - '0';
        }

        static string Base10ToBaseX(int number, int x)
        {
            string result = String.Empty;
            for (; number != 0; number /= x)
                result = NumberToChar(number % x) + result;
            
            return result;
        }
        //any base >=2 to Base10
        static int ConvertToBase10(string result, int x)
        {
            int number = 0;

            for (int i = result.Length - 1, p = 1; i >= 0; i--, p *= x)
                number += StringToNumber(result, i) * p;

            return number;
        }

        static string AnyBaseConvertSwitch(string input, int s, int d)
        {
            //temporary passing through Base10
            return Base10ToBaseX(ConvertToBase10(input, s), d);
        }
    }
}