/*
 * Write a method that finds the longest subsequence
 * of equal numbers in given List<int> and returns
 * the result as new List<int>. Write a program to
 * test whether the method works correctly.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() { 0, 1, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4 };
        //TODO data reader from file
        List<int> bestSubSequence = LongestSubSequence(numbers);

        Console.Write("Longest subsequence with equal numbers in { ");
        foreach (var number in numbers)
            Console.Write(number + " ");

        Console.Write("}\nis { ");
        foreach (int number in bestSubSequence)
            Console.Write(number + " ");

        Console.WriteLine("}");
    }

    private static List<int> LongestSubSequence(List<int> sequence)
    {
        var result = new List<int>();
        int currentCount = 1;
        int bestNumber = 0;
        int bestCount = 1;

        for (int index = 0; index < sequence.Count - 1; index++)
        {
            if (sequence[index] == sequence[index + 1])
            {
                currentCount++;
                if (index == sequence.Count - 2)
                {
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestNumber = sequence[index];
                    }
                }
            }
            else
            {
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestNumber = sequence[index];
                }
                
                currentCount = 1;
            }
        }

        for (int index = 0; index < bestCount; index++) 
            result.Add(bestNumber);

        return result;
    }
}
