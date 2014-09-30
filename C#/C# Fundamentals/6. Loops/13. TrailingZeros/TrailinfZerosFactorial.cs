namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// * Write a program that calculates for given N how many trailing zeros present at the end
    /// of the number N!.
    /// Examples:
    ///     N = 10  N! = 3628800  2	
    ///     N = 20  N! = 2432902008176640000  4
    /// Does your program work for N = 50 000?
    /// Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5.
    /// </summary>
    class Task13
    {
        static void Main()
        {
            Console.Write("Input number N for Factorial sequence (1 ... N!):  "); 
            int numberN = int.Parse(Console.ReadLine());

            Console.WriteLine("\n{0}! have {1} trailing zeros", numberN, TrailingZerosCalc(numberN)); 
           
        }

        /// <summary>
        /// Calc trailing zeros for given factorial by division of power of 5
        /// (number = 50000) -> 12499 trailing zeros
        /// </summary>
        /// <param name="number"></param>
        static int TrailingZerosCalc(int number)
        {
            int zerosCounter = 0;
            for (int index = 5; index <= number; index *= 5)
            {
                zerosCounter += number / index;
            }

            return zerosCounter;
        }
    }
}