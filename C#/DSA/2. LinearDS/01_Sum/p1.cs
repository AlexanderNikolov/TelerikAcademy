/*
 * Write a program that reads from the console a
 * sequence of positive integer numbers. The sequence
 * ends when empty line is entered. Calculate and print
 * the sum and average of the elements of the
 * sequence. Keep the sequence in List<int>.
 */

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int number;
        int sum = 0;
        var elements = new List<int>();

        Console.Write("Input number: ");
        string input = Console.ReadLine();

        while (int.TryParse(input, out number))
        {
            if (number >= 0)
            {
                elements.Add(number);
                sum += number;
            }

            Console.Write("Input number or Enter to stop: ");
            input = Console.ReadLine();
        }

        Console.WriteLine("\nSum is: {0}", sum);
        Console.WriteLine("Average sum (sum/elements) is: {0}\n", sum / elements.Count);
    }
}
