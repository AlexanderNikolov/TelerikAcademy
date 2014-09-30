namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// Write a program to calculate the Nth Catalan number by given N.
    /// Example:
    ///     (0) -> 1
    ///     (1) -> 1
    ///     (2) -> 2
    ///     (3) -> 5
    /// </summary>
    class CathalanFormula
    {
        static void Main()
        {
            Console.Write("Input number N (0..25):  "); 
            double numberN = double.Parse(Console.ReadLine());

            Console.WriteLine(cathalanCalc(numberN));
        }

        /// <summary>
        /// Fastest algorithm for Catalan sequence
        /// </summary>
        static double cathalanCalc(double number)
        {
            return number == 0 ? 1 : ((2 * (2 * number - 1)) / (number + 1)) * cathalanCalc(number - 1);
        }
    }
}