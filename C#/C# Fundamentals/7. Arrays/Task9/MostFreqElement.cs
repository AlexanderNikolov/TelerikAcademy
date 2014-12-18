/*
 * Write a program that finds the most frequent number in an array. 
 * Example:	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MostFreqElement
    {
        static void Main(string[] args)
        {
            int[] input = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            List<int> workList = new List<int>(input);

            //almost twilight zone, but do the job! 
            int mostFrequent = workList
                              .GroupBy(i => i)
                              .OrderByDescending(grp => grp.Count())
                              .Select(grp => grp.Key)
                              .First();

            //output
            int count = 0;
            foreach (int item in workList)
            {
                if (item == mostFrequent)
                    count++;
            }
            Console.Write(mostFrequent);
            Console.WriteLine(" ({0} times)", count);
        }
    }
}
