using System;
using System.Collections.Generic;
using System.Linq;


class MostFrequentCharInArray_method
{
    static void Main()
    {
        //Write a method that counts how many times given number appears in 
        //given array. Write a test program to check if the method is working correctly 
        
        int[] testArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int testNumber = 2;

        //test method by changing number and input array 
        Console.WriteLine("Number {0} -> {1} times", testNumber, MostFrequentChar(testArray, testNumber));
    }

    public static int MostFrequentChar(int[] array, int number)
    {
        List<int> list = new List<int>(array);

        //System.Collections - IEnumerable Interface - .NET 4.5 - lambda expressions
        int mostFrequent =
                            list
                            .GroupBy(i => number)
                            .OrderByDescending(grp => grp.Count())
                            .Select(grp => grp.Key)
                            .First();

        int count = 0;
        foreach (int item in list)
        {
            if (item == mostFrequent)
                count++;
        }

        return count;
    }

}


