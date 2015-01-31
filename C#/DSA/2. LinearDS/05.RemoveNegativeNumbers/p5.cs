/*
 * Write a program that removes from given sequence
 * all negative numbers.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var elements = new List<int>() { 0, 1, 2, -2, 3, -3, -3, -3, -3, 4, -4, -4, -4 };
        
        //TODO data reader from file
        Console.WriteLine(string.Join(", ", NegativeElementsRemoving(elements)));

    }

    static List<int> NegativeElementsRemoving(List<int> sample)
    {
        List<int> result = new List<int>();
        foreach (var item in sample)
        {
            if (item >= 0)
                result.Add(item);
        }

        return result;
    }
}