/*
 * Write a program that reads two arrays from the console and compares them element by element.
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class Task2
    {
        static void Main(string[] args)
        {
            const int ArrSize = 5;

            int[] firstArr = new int[ArrSize];
            int[] secondArr = new int[ArrSize];
            bool isArraysEqual = true;

            //first case - number arrays with equal size
            for (int index = 0; index < ArrSize; index++)
            {
                Console.Write("\nInput number for element {0}/{1} for first array: ", index, ArrSize);
                firstArr[index] = int.Parse(Console.ReadLine());
                Console.Write("Input number for element {0}/{1} for second array: ", index, ArrSize);
                secondArr[index] = int.Parse(Console.ReadLine());

                if (firstArr[index] != secondArr[index])
                {
                    isArraysEqual = false;
                }
            }

            Console.WriteLine("\nfirstArray = { " + string.Join(", ", firstArr) + "}");
            Console.WriteLine("secondArray = { " + string.Join(", ", secondArr) + "}");
            if (isArraysEqual)
            {
                Console.WriteLine("\nArrays are equal!");
            }
            else
            {
                Console.WriteLine("\nWe have different arrays here!");
            }
        }
    }
}