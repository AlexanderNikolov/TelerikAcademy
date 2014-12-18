/*
 * Write a program that reads three integer numbers N, K and S and an array 
 * of N elements from the console. Find in the array a subset of K elements 
 * that have sum S or indicate about its absence.
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;
    using System.Collections.Generic;

    class EratosthenesSieve
    {
        static void Main(string[] args)
        {
            Console.Write("Input N for array of N elements "); int numberN = int.Parse(Console.ReadLine());
            Console.Write("Input K for subset of K elements "); int numberK = int.Parse(Console.ReadLine());
            Console.Write("Input S for subset sum "); int numberS = int.Parse(Console.ReadLine());

            //init
            int[] numbers = new int[numberN];
            List<int> workingList = new List<int>();

            for (int ii = 0; ii < numberN; ii++)
            {
                Console.Write("Input array element {0}/{1} ", ii+1, numberN);
                numbers[ii] = int.Parse(Console.ReadLine());
            }

            //Exponential time algorithm
            int subsetLenght = 0;
            int limit = (int)Math.Pow(2, numbers.Length);
            bool isFound = false;

            for (int ii = 1; ii <= limit; ii++)
            {
                int currentSum = 0;
                for (int jj = 1; jj <= numbers.Length; jj++)
                {
                    if (((ii >> (jj - 1)) & 1) == 1)
                    {
                        currentSum += numbers[jj - 1];
                        subsetLenght++;
                        workingList.Add(numbers[jj - 1]);
                    }
                }

                if (subsetLenght == numberK && currentSum == numberS)
                {
                    isFound = true;
                    break;
                }
                else
                {
                    subsetLenght = 0;
                    workingList.Clear();
                }
            }

            //output
            if (isFound)
            {
                Console.Write("{" + string.Join(", ", numbers) + "}" + "  yes ");
                Console.WriteLine("(" + string.Join(", ", workingList) + ")");
            }
            else
            {
                Console.WriteLine("\nNo solution found!");
            }
        }
    }
}