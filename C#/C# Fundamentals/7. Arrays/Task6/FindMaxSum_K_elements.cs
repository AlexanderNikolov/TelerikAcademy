/*
 * Write a program that reads two integer numbers N and K and an array 
 * of N elements from the console. Find in the array those K elements 
 * that have maximal sum.
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class FindMaxSum_K_elements
    {
        static void Main(string[] args)
        {
            int sizeN;
            int numberK;
            int maxSum = 0;

            Console.Write("Input numberN for array size ");
            sizeN = int.Parse(Console.ReadLine());
            Console.Write("Input numberK of elements forming max sum [K<N] ");
            numberK = int.Parse(Console.ReadLine());

            int[] numbers = new int[sizeN];
            for (int i = 0; i < sizeN; i++)
            {
                Console.Write("Input array element {0}/{1} ", i, sizeN - 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            for (int j = 0; j < numberK; j++)
            {
                maxSum += numbers[sizeN - 1 - j];
            }

            Console.WriteLine("Max sum of {0} elements is {1}", numberK, maxSum);
        }
    }
}
