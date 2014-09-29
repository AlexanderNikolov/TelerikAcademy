namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// Write a program that reads an integer number n from the console and prints all the numbers
    /// in the interval [1..n], each on a single line;
    /// </summary>
    class Task8
    {
        static void Main()
        {
            Console.Write("Enter integer number "); 
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0}  ", i);
            }
        }
    }
}