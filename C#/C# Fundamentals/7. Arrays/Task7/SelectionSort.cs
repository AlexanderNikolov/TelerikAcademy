/*
 * Sorting an array means to arrange its elements in increasing order. 
 * Write a program to sort an array. Use the "selection sort" algorithm: 
 * Find the smallest element, move it at the first position, find the smallest 
 * from the rest, move it at the second position, etc.
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 7, 8, 4, 1, 9, 3, 2, 6 };

            SelectionSort(numbers);
            Console.WriteLine(string.Join(", ", numbers));
        }

        static void SelectionSort(int[] array)
        {
            int count = 0;
            while (count < array.Length)
            {
                //int currentElement = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int currentElement = array[count];
                    if (currentElement < array[i]) // if '>' result goes decreasing order
                    {
                        array[count] = array[i];
                        array[i] = currentElement;
                    }
                }

                count++;
            }
        }
    }
}
