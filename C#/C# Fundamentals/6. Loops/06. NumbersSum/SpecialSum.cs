namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// Write a program that, for a given two integer numbers N and X, calculates the sum
    /// S = 1 + 1!/X + 2!/X2 + … + N!/XN
    /// </summary>
    class Task6
    {
        static void Main()
        {
            Console.Write("Input number N  "); 
            int numberN = int.Parse(Console.ReadLine());
            Console.Write("Input number X)  "); 
            int numberX = int.Parse(Console.ReadLine());

            decimal specialSum = 1;

            for (int i = 1; i <= numberN; ++i)
            {
                specialSum += factorialCalc(i) / (decimal)Math.Pow(numberX, i);
            }

            Console.WriteLine("{0:0.0000}", specialSum);
        }

        static int factorialCalc(int number)
        {
            return number <= 1 ? 1 : number * factorialCalc(number - 1);
        }
    }
}