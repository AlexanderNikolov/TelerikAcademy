/*
 * Write a program that removes from given sequence
 * all numbers that occur odd number of times.
 * Example:
 *      {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}   {5, 3, 3, 5}
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
        
        //TODO data reader from file
        Console.WriteLine(string.Join(", ", RemoveOddOccureElements(numbers)));
    }

    static List<int> RemoveOddOccureElements(List<int> numbers)
    {
        var separator = new Dictionary<int, int>();
        foreach (var number in numbers)
        {
            if (!separator.ContainsKey(number))
                separator.Add(number, 1); 
            else
                separator[number]++; 
        }

        var result = numbers.Where(x => separator[x] % 2 == 0);

        return result.ToList();
    }
}
