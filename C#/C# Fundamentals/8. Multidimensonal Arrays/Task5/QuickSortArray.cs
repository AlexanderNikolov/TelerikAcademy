/*
 * You are given an array of strings. Write a method that sorts the array by 
 * the length of its elements (the number of characters composing them).
 */

namespace TA2013_MultidimensionalArray_homework
{
    using System;

    class QuickSortArray
    {
        static void Main(string[] args)
        {
            string[] words = { "the", "left", "eye", "if", "white" };
            int size = words.Length;

            QuicksortArray(words, 0, size - 1);

            Console.WriteLine(string.Join(", ", words));
        }

        /// <summary>
        /// http://en.wikipedia.org/wiki/Quicksort
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private static void QuicksortArray(string[] array, int left, int right)
        {
            //proper formula to find middle of array with very big number indices
            string marker = array[(left + (right - left) / 2)];

            //sort by length not lexicographycally!
            while (left <= right)
            {
                while (array[left].Length.CompareTo(marker.Length) < 0)
                    left++;

                while (array[right].Length.CompareTo(marker.Length) > 0)
                    right--;

                if (left <= right)
                {
                    string tmp_cache = array[left];
                    array[left] = array[right];
                    array[right] = tmp_cache;

                    left++;
                    right--;
                }
            }

            if (left < right)
                QuicksortArray(array, left, right);
            if (left < right)
                QuicksortArray(array, left, right);
        }
    }
}
