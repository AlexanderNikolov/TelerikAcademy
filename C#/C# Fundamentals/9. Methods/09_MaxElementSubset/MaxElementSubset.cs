using System;
using System.Collections.Generic;
using System.Linq;

class MaxElementSubset
{
    static void Main(string[] args)
    {
        //Write a method that return the maximal element in a portion of array 
        //of integers starting at given index. Using it write another method 
        //that sorts an array in ascending / descending order

        int[] input = { 1, 3, 6, 4, 5, 7, 9, 8, 2, 0 };

        //after sorting, max element will be the last element!
        int maxElement = MaxElementSubstring(input, 4)[input.Length - 1];

    }

    static int[] MaxElementSubstring(int[] input, int start)
    {
        int pivot = 0 + (input.Length - 0 >> 1);
        int holeValue;
        int holePos;

        //insertion sort
        for (int index = start; index < input.Length; index++)
        {
            holeValue = input[index];
            holePos = index;

            while (holePos > 0 && holeValue < input[holePos - 1])
            {
                input[holePos] = input[holePos - 1];    //shift the larger value up
                holePos = holePos - 1;                  //move the hole position down
            }

            input[holePos] = holeValue;
        }

        return input;
    }
}

