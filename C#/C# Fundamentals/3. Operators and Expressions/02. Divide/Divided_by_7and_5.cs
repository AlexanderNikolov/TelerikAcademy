namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Write a boolean expression that checks for given integer if it
    /// can be divided (without remainder) by 7 and 5 in the same time;
    /// </summary>
    class Task2
    {
        static void Main()
        {
            Console.Write("Enter integer number!: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 35 == 0)
            {
                Console.WriteLine("{0} can be divided by 7 and 5 at same time!", number);
            }
            else
            {
                Console.WriteLine("{0} can\'t be divided by 7 and 5 at same time!", number);
            }
        }
    }
}