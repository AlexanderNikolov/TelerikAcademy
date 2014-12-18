using System;
using System.Collections.Generic;
using System.Linq;

class AddNumbersMethod
{
    static void Main(string[] args)
    {
        //Write a method that adds two positive integer numbers represented as 
        //arrays of digits (each array element arr[i] contains a digit; the last 
        //digit is kept in arr[0]). Each of the numbers that will be added could 
        //have up to 10 000 digits.

        int[] inputA = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] inputB = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Printer(BigIntegerAdd(inputA, inputB));

    }
    //method to add BigInteger numbers (separate digits in array indexes)
    static List<int> BigIntegerAdd(int[] inputA, int[] inputB)
    {
        int length = Math.Max(inputA.Length, inputB.Length);
        var result = new List<int>(length);

        int carry = 0;

        for (int i = 0; i < length; i++)
        {

            int currentDigit = (i < inputA.Length ? inputA[i] : 0) + (i < inputB.Length ? inputB[i] : 0) + carry;

            carry = currentDigit / 10;
            result.Add(currentDigit % 10);
        }
        if (carry == 1) result.Add(1);

        return result;
    }
    static void Printer(List<int> input)
    {
        for (int index = input.Count - 1; index >= 0; index--)
            Console.Write(input[index]);
    }

}

