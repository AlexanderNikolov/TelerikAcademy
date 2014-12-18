/*
 * Write a program that finds the maximal sequence of equal elements in an array.
 * 		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class Task4
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int size = numbers.Length;
            int max = 1; //maximal sequence of equal elements in an array
            int tempMax = 1;
            int currentElement = 0;
            int element = 0;

            for (int i = 0; i < size; i++)
            {
                if (i != size - 1)
                {
                    if (numbers[i] == numbers[i+1])
                    {
                        currentElement = numbers[i];
                        tempMax++;
                    }
                    else
                        tempMax = 1;

                    if (tempMax > max)
                    {
                        max = tempMax;
                        element = currentElement;
                    }
                }
            }

            //dumb output :)
            Console.Write('{');
            for (int i = 0; i < max; i++)
            {
                Console.Write(element);
                if (i != max - 1)
                    Console.Write(", ");    
                
            }
            Console.WriteLine('}');
        }
    }
}