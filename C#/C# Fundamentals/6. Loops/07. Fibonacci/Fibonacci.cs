namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// Write a program that reads a number N and calculates the sum of the first N members
    /// of the sequence of Fibonacci: : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ..
    /// </summary>
    class Fibonacci
    {
        static void Main()
        {
            Console.Write("Input number N for Fibonacci sequence 0, 1 .. N: "); 
            int numberN = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of {0} Fibonacci numbers: {1}", numberN, fibonacciCalc(numberN) - 1);
        }

        /// <summary>
        /// Dont use this in real projects! Simple and pritty code but very resource harmfull and not
        /// efficient. For example only!
        /// </summary>
        public static int fibonacciCalc(int number)
        {
            return number <= 1 ? 1 : fibonacciCalc(number - 2) + fibonacciCalc(number - 1); //recursion
        }
    }
}