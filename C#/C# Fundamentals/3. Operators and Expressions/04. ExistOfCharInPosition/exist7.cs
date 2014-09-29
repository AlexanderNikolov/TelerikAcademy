namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Write an expression that checks for given integer if its third digit
    /// (right-to-left) is 7. E. g. 1732  true.";
    /// </summary>
    class Task4
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            string number = Console.ReadLine();

            if (number[number.Length - 3] == '7')
            {
                Console.WriteLine(number + " true");
            }
            else
            {
                Console.WriteLine(number + " false");
            }
        }
    }
}