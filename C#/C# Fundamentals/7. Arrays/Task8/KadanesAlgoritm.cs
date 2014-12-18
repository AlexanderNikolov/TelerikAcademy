/*
 * Write a program that finds the sequence of maximal sum in given array. 
 * Example:	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)?
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;
    using System.Collections.Generic;

    class KadanesAlgoritm
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            List<int> workList = new List<int>(numbers);

            int startIndex = 0;
            int endIndex = 0;
            int currentIndex = 0;
            int maxSum = 0;
            int currentSum = 0;

            //Kadane's algorithm
            for (int ii = 0; ii < workList.Count; ii++)
            {
                currentSum += workList[ii];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndex = currentIndex;
                    endIndex = ii;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                    currentIndex = ii + 1;
                }
            }

            //dumb output :)
            Console.Write('{');
            for (int jj = startIndex; jj <= endIndex; jj++)
            {
                Console.Write("{0}", workList[jj]);
                if (jj < endIndex) 
                    Console.Write(", ");
            }
            
            Console.WriteLine('}');
        }
    }
}
