/*
 *  * The majorant of an array of size N is a value that occurs in it at least 
 *  N/2 + 1 times. Write a program to find the majorant of given array (if exists). 
 * Example:
 *      {2, 2, 3, 3, 2, 3, 4, 3, 3}    3
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
        //TODO add array reader from file

        int result = FindMajorant(array);
        if (result == -1)
            Console.WriteLine("No majorant!");
        else
            Console.WriteLine("Majorant: {0}", result);
    }

    private static int FindMajorant(int[] array)
    {
        var separator = new Dictionary<int, int>();
        foreach (var item in array)
        {
            if (separator.ContainsKey(item))
                separator[item]++;
            else
                separator.Add(item, 1);
        }

        int toSatisfy = (int)array.Length / 2 + 1;
        int result;
        try
        {
            result = separator.First((item) => item.Value >= toSatisfy).Key;
        }
        catch (System.InvalidOperationException)
        {
            result = -1;
        }
        
        return result;
    }
}