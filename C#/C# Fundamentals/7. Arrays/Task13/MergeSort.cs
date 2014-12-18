/*
 * Write a program that sorts an array of integers using the merge sort algorithm
 * (find it in Wikipedia).
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class MergeSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 16, 17, 18, 19, 20, 11, 12, 13, 14, 15 };
            Console.WriteLine("unsorted: {0}",string.Join(", ", numbers));

            int size = numbers.Length;
            int[] working = new int[size];
            int step = 1;

            while (step < size)
            {
                int index = 0;

                while (index < (size - step))
                {
                    int left = index;
                    int mid = index + step;
                    int right;

                    if (index + 2 * step - 1 < size - 1)
                    {
                        right = index + 2 * step - 1;
                    }
                    else
                    {
                        right = size - 1;
                    }

                    int leftEnd = index + step - 1;
                    int tempPosition = index;
                    int numElements = right - left + 1;
                    while ((left <= leftEnd) && (mid <= right))
                    {
                        if (numbers[left] <= numbers[mid])
                        {
                            working[tempPosition] = numbers[left];
                            tempPosition++;
                            left++;
                        }
                        else
                        {
                            working[tempPosition] = numbers[mid];
                            tempPosition++;
                            mid++;
                        }
                    }

                    while (left <= leftEnd)
                    {
                        working[tempPosition] = numbers[left];
                        tempPosition++;
                        left++;
                    }

                    while (mid <= right)
                    {
                        working[tempPosition] = numbers[mid];
                        tempPosition++;
                        mid++;
                    }

                    for (int j = 0; j < numElements; j++)
                    {
                        numbers[right] = working[right];
                        right = right - 1;
                    }

                    index = index + 2 * step;
                }

                step = step * 2;
            }

            Console.WriteLine("sorted:   {0}", string.Join(", ", numbers));
        }
    }
}
