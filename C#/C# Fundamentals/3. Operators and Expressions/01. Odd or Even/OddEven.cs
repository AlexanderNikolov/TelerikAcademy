namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Write an expression that checks if given integer is odd or even;
    /// </summary>
    class Task1
    {
        static void Main()
        {
            Console.Write("Enter integer number!: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                Console.WriteLine("{0} is odd!", number);
            }
            else
            {
                Console.WriteLine("{0} is even!", number);
            }
        }
    }
}