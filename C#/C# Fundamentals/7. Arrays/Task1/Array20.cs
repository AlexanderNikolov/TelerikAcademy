/*
 * Write a program that allocates array of 20 integers and initializes each element
 * by its index multiplied by 5. Print the obtained array on the console.
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class Task1
    {
        static void Main(string[] args)
        {
            const int ArrSize = 20;
            const int Multiplier = 5;

            int[] numbers = new int[ArrSize];

            for (int index = 0; index < ArrSize; index++)
            {
                numbers[index] = index * Multiplier;
            }

            Console.WriteLine("\nArray = { " + string.Join(", ", numbers) + "}");
        }
    }
}