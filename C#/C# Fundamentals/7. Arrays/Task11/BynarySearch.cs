/*
 * Write a program that finds the index of given element in a sorted array
 * of integers by using the binary search algorithm (find it in Wikipedia).
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class BynarySearch
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int keyValue = 7; //test here with different values for search

            string negativeResultMessage = "Searched value not found!";
            string possitiveResultMessage = "Value found at index {0}";

            int result = BinarySearch(numbers, keyValue);

            //output
            if (result == -1)
                Console.WriteLine(negativeResultMessage);
            else
                Console.WriteLine(possitiveResultMessage, result);
        }

        public static int BinarySearch<T>(T[] arr, T value)
            where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + (endIndex - startIndex) / 2);
                if (arr[midIndex].Equals(value))
                    return midIndex; //searched value found and return

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    startIndex = midIndex + 1; //search right
                }
                else
                {
                    endIndex = midIndex - 1; //search left
                }
            }

            return -1;
        }
    }
}
