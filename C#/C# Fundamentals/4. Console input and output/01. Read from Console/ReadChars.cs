namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// Write a program that reads 3 integer numbers from the console and prints their sum;
    /// </summary>
    class Task1
    {
        static void Main()
        {
            Console.Write("Enter integer number: "); 
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter integer number: "); 
            int numberB = int.Parse(Console.ReadLine());
            Console.Write("Enter integer number: "); 
            int numberC = int.Parse(Console.ReadLine());

            int numberSum = numberA + numberB + numberC;

            Console.WriteLine("Sum of numbers {0}, {1} and {2} is: {3} ", 
                numberA, numberB, numberC, numberSum);
        }
    }
}