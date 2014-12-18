/*
 * Write a program that finds in given array of integers a sequence of 
 * given sum S * (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class CheckForGivenSum
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 3, 1, 4, 2, 5, 8, 10, 6, 6, 1, 0 };

            const int S = 15;

            int startIndex = 0;
            int endIndex = 0;
            int currentSum = 0;

            //my own algorithm :)
            for (int ii = 0; ii < numbers.Length; ii++)
            {
                currentSum += numbers[ii];

                if (currentSum == S)
                {
                    endIndex = ii;
                    break;
                }
                if (currentSum > S)
                {
                    //decrease sum with first and last number. Last number will be added again 
                    //after decreasing of index!
                    currentSum -= numbers[startIndex] + numbers[ii];
                    startIndex++;
                    ii--;
                }
            }

            //output
            Console.Write("S={0} ? ( ", S);
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine(")");
        }
    }
}
