using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerElementLeftRight
{
    class BiggerElementLeftRightInArray
    {
        static void Main()
        {
            //Write a method that checks if the element at given position in given 
            //array of integers is bigger than its two neighbors (when such exist)

            int[] testArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //test with 0, 3, 11, 12
            int testPosition = 0;

            BiggerFromLeftRightInArray(testArray, testPosition);
        }

        public static void BiggerFromLeftRightInArray(int[] array, int position)
        {
            const string bigger = "Element at given position is bigger";
            const string message = "Only one neghbour left or right!";
            const string error = "Out of array range!";

            if (position < 0 || position > array.Length - 1)
            {
                Console.WriteLine(error);
            }
            else if (position == 0)
            {
                if (array[position] > array[position + 1])
                {
                    Console.WriteLine(message + " " + bigger);
                }
            }
            else if (position == array.Length - 1)
            {
                if (array[position] > array[position - 1])
                {
                    Console.WriteLine(message + " " + bigger);
                }
            }
            else
            {
                if (array[position] > array[position -1] && array[position] > array[position + 1])
                {
                    Console.WriteLine(bigger);
                }
                else
                {
                    Console.WriteLine("Negative result");
                }
            }

        }
    }
}
