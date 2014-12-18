/*
 * Write a program that finds the maximal increasing sequence in an array. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;
    using System.Collections.Generic;

    class MaxIncrSequenceArray
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 3, 4, 2, 2, 4 };

            Console.WriteLine(string.Join(", ", FindMaxIncrSequence(numbers)));
           
        }

        static List<int> FindMaxIncrSequence(int[] array)
        {
            if (array.Length == 1)
            {
                return new List<int>() { array[0] };
            }

            List<int> maxIncrSequence = new List<int>() { array[0] };
            List<int> bestSequence = new List<int>();

            int currentElement = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > currentElement)
                {
                    maxIncrSequence.Add(array[i]);
                    currentElement = array[i];
                }
                else
                {
                    currentElement = array[i];
                    maxIncrSequence = new List<int>() { currentElement };
                }

                if (maxIncrSequence.Count >= bestSequence.Count)
                    bestSequence = new List<int>(maxIncrSequence);
            }

            if (bestSequence.Count == 1 && bestSequence[0] == array[array.Length - 1])
            {
                // Example: 6 5 4 3 2 1 -> return 6 instead any other element
                return new List<int>() { array[0] };
            }
            else 
                return bestSequence;
        }
    }
}
