namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// Write a program that prints all the numbers from 1 to N.
    /// </summary>
    class Task1
    {
        static void Main()
        {
            Console.Write("Input number for end of sequence (1 2 3 ... N)"); 
            int numberN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberN; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}