/*
 * Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number 
 * in the array which is ≤ K. 
 */

namespace TAOnline_8_Multidimensional_Arrays
{
    using System;

    class ArrayLargestNumberWithBSearch
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.Write("Input N for array size: ");
            int sizeN = int.Parse(Console.ReadLine());
            Console.Write("Input value K for searching criteria: ");
            int markerK = int.Parse(Console.ReadLine());

            int[] numbers = new int[sizeN];

            for (int i = 0; i < sizeN; i++)
            {
                numbers[i] = rnd.Next(sizeN);
            }

            
            Array.Sort(numbers); //necessary condition for using BinarySearch()

            //searching in array using BinarySearch()
            int index = Array.BinarySearch(numbers, markerK);

            //processing of the results and output
            Console.WriteLine(string.Join(", ", numbers));
            if (index < 0)
            {
                Console.WriteLine("The searching value not found. The last larger value is {0}.", 
                    numbers[~index - 1]);
            }
            else
            {
                Console.WriteLine("The value found at index {0}.", index);
            }
        }
    }
}
