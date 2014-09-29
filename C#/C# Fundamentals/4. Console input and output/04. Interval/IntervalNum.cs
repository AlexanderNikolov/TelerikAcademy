namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// Write a program that reads two positive integer numbers and prints how many numbers p
    /// exist between them such that the reminder of the division by 5 is 0 (inclusive).
    /// Example: p(17,25) = 2;
    /// </summary>
    class Task4
    {
        static void Main()
        {
            int numberA, numberB;
            int count = 0;

            Console.Write("Enter first integer number: "); numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer number: "); numberB = int.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                int bigger = numberA;
                numberA = numberB;
                numberB = bigger;
            }

            for (int i = numberA; i <= numberB; i++)    //calculate remainders of the division by 5
            {
                if (i % 5 == 0)
                {
                    count += 1;
                }
            }

            Console.WriteLine("p({0}, {1}) = {2}", numberA, numberB, count);
        }
    }
}