/*
 * Write a program that finds in given array of integers
 * (all belonging to the range [0..1000]) how many
 * times each of them occurs.
 * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
 *      2   2 times
 *      3   4 times
 *      4   3 times
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var elements = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
        
        //TODO data reader from file
        foreach (var item in GetOccureElements(elements))
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
    }

    private static Dictionary<int, int> GetOccureElements(List<int> numbers)
    {
        var separator = new Dictionary<int, int>();
        foreach (var number in numbers)
        {
            if (!separator.ContainsKey(number))
                separator.Add(number, 1);
            else
                separator[number]++;
        }

        return separator;
    }
}