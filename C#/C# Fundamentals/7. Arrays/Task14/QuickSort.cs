/*
 * Write a program that sorts an array of strings using the quick sort algorithm.
 * (find it in Wikipedia).
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            Quicksort(numbers);
            Console.Write(string.Join(", ", numbers)); Console.WriteLine();
        }

        static void Quicksort<T>(T[] array) 
            where T : IComparable
        {
            QuicksortArray(array, 0, array.Length - 1);
        }

        static void QuicksortArray<T>(T[] array, int left, int right) 
            where T : IComparable
        {
            int i = left, 
                j = right;

            var marker = array[(left + (right - left) / 2)];

            while (i <= j)
            {
                while (array[i].CompareTo(marker) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(marker) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    var tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
                QuicksortArray(array, left, j);
            
            if (i < right) 
                QuicksortArray(array, i, right);
        }
    }
}