namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8,
    /// 13, 21, 34, 55, 89, 144, 233, 377, …");
    /// </summary>
    class Fibonacci
    {
        static void Main()
        {
            decimal firstSeed = 0;
            decimal secondSeed = firstSeed + 1;

            for (int i = 0; i < 100; i++)  
            {
                decimal tempValue = firstSeed;
                firstSeed = secondSeed;
                secondSeed += tempValue; //one possible method to calculate Fibonacci sequence

                Console.Write("{0} ", firstSeed);
            }
        }
    }
}