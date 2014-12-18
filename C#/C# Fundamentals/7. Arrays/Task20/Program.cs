/*
 * Write a program that reads two numbers N and K and generates all the variations 
 * of K elements from the set [1..N]. 
 * Example:
 * 	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
 */

namespace Task20
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input size of set N "); int numberN = int.Parse(Console.ReadLine());
            Console.Write("input number of elements K "); int numberK = int.Parse(Console.ReadLine());

            int index = numberK - 1;
            int stopFlag = 0;
            List<int> listOfResults = new List<int>();

            for (int i = 0; i < numberK; i++)
            {
                listOfResults.Add(1);
            }

            while (true)
            {
                foreach (int item in listOfResults)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
                while (index > -1 && listOfResults[index] == numberN)
                {
                    stopFlag = listOfResults[index];
                    listOfResults[index] = 1;
                    index--;
                }

                //conditions for end
                if (index == -1 && stopFlag == numberN)
                    break;

                listOfResults[index]++;
                index = numberK - 1;
            }
        }
    }
}
