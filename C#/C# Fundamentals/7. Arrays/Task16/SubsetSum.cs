/*
 * We are given an array of integers and a number S. Write a program to find 
 * if there exists a subset of the elements of the array that has a sum S. 
 * Example:
 *  	arr = {2, 1, 2, 4, 3, 5, 2, 6}, S = 14  yes (1 + 2 + 5 + 6)
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SubsetSum
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int sumS = 14; //change here for tests!

            FindSubsetSum(numbers, sumS);
        }

        static void FindSubsetSum(int[] numbers, int s)
        {
            List<int> workingList = new List<int>();

            int subsetsCount = (int)(Math.Pow(2, numbers.Length) - 1); // number of eventual subsets
            bool isFound = false;
            
            for (int ii = 1; ii <= subsetsCount; ii++)
            {
                workingList.Clear();
                for (int jj = 0; jj < numbers.Length; jj++)
                {
                    if (((ii >> jj) & 1) == 1) workingList.Add(numbers[jj]);
                }

                if (workingList.Sum() == s) //method Sum() come from System.Linq!
                {
                    isFound = true;
                    //dumb output exactly like example ;)
                    Console.WriteLine(
                        "arr = {" 
                        + string.Join(", ", numbers) 
                        + "}, " 
                        + s
                        + "  yes ( " 
                        + string.Join("+ ", workingList) 
                        + ")"
                    );
                }
            }
        }
    }
}