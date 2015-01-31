/*
 * Write a program that reads N integers from the
 * console and reverses them using a stack. Use the
 * Stack<int> class.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int current;
        var elements = new Stack<int> ();
        
        Console.Write("Type number and press Enter: ");
        string input = Console.ReadLine();
        
        while (int.TryParse(input, out current))
        {
            elements.Push(current);
            Console.Write("Type number or just Enter to stop: ");
            input = Console.ReadLine();
        }

        while (elements.Count > 0)
        {
            current = elements.Pop();
            Console.Write(current + " ");
        }
        Console.WriteLine();
    }
}
