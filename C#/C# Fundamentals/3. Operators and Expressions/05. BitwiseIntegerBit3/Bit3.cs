namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Write a boolean expression for finding if the bit 3
    /// (counting from 0) of a given integer is 1 or 0.";
    /// </summary>
    class Task5
    {
        static void Main()
        {
            Console.Write("Enter integer: ");
            int number = int.Parse(Console.ReadLine());
            byte bitwiseMask = 4;

            if ((number & bitwiseMask) == 4) //bitwise operation - number AND mask  
            {
                Console.WriteLine("{0}, have value 1 in 3rd bit position", number);
            }
            else
            {
                Console.WriteLine("{0}, have value 0 in 3rd bit position", number);
            }
        }
    }
}