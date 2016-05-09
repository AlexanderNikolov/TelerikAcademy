/*
 * * Write a program that reads an array of integers and removes from it a minimal number
 * of elements in such way that the remaining array is sorted in increasing order. 
 * Print the remaining sorted array. 
 * Example:
 *  	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
 *  	{ 6, 6, 5, 4, 3, 2, 1, 3, 1, 2, 3, 4, 5, 6, 3, 2, 1, 2, 1, 2, 3 } -> { 1, 1, 2, 3, 4, 5, 6 }
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;
    using System.Collections.Generic;

    class SortingByRemoving
    {
        static List<int>[] allBestSubsets = new List<int>[40];
        static int index = 0;

        static void Main(string[] args)
        {
            int[] numbers = { 6, 6, 5, 4, 3, 2, 1, 3, 1, 2, 3, 4, 5, 6, 3, 2, 1, 2, 1, 2, 3 };

            FindAllSubsetsWithGivenSum(numbers);

            Console.WriteLine("Longest subset(s) with increasing elements: ");
            for (int i = 0; i < index; i++)
                Console.WriteLine(string.Join(" ", allBestSubsets[i]));
        }

        static void FindAllSubsetsWithGivenSum(int[] numbers)
        {
            List<int> subset = new List<int>();
            long bestLength = 0;
            long totalSubsets = (long)(Math.Pow(2, numbers.Length) - 1); // number of possible subsets

            //for (int i = 1; i <= totalSubsets; i++)
            for (long i = totalSubsets; i >= 1; i--)
            {
                long elementInSubset = ElementsInSubset(i);

                if (elementInSubset < bestLength)
                {
                    continue;
                }

                subset.Clear();
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (((i >> j) & 1) == 1)
                        subset.Add(numbers[j]);
                }

                if (IsIncreasingElements(subset))
                {
                    if (bestLength < elementInSubset)
                    {
                        allBestSubsets = new List<int>[40];
                        index = 0;
                    }

                    bestLength = elementInSubset;

                    allBestSubsets[index++] = new List<int>(subset);
                }
            }
        }

        // Optimization method
        static long ElementsInSubset(long currentNumber)
        {
            long elementsInSubset = 0;
            while (currentNumber != 0)
            {
                elementsInSubset += currentNumber & 1;
                currentNumber >>= 1;
            }

            return elementsInSubset;
        }

        static bool IsIncreasingElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                    return false;
            }

            return true;
        }
        
        //best variant for this task
        private static int sortingByRemoving(List<int> input)
        {
            int[] sortedNumsCount = Enumerable.Repeat(1, input.Count).ToArray();

            int maxSortedNums = 1;
            for (int i = 1; i < input.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] >= input[j] && sortedNumsCount[i] <= sortedNumsCount[j] + 1)
                    {
                        sortedNumsCount[i] = sortedNumsCount[j] + 1;
                        if (maxSortedNums < sortedNumsCount[i])
                        {
                            maxSortedNums = sortedNumsCount[i];
                        }
                    }
                }
            }

            return maxSortedNums;
        }
    }
}
