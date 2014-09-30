namespace TAonline.CSharp.ConditionalStatements.Homework5
{
    using System;

    /// <summary>
    /// Write a program that shows the sign (+ or -) of the product of three real numbers
    /// without calculating it. Use a sequence of if statements.
    /// </summary>
    class ShowSign
    {
        static void Main()
        {
            Console.Write("Enter real integer number "); 
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter real integer number "); 
            int numberB = int.Parse(Console.ReadLine());
            Console.Write("Enter real integer number "); 
            int numberC = int.Parse(Console.ReadLine());

            string signPlus = "Product of three numbers is possitive";
            string signMinus = "Product of three numbers is negative";

            if (numberA > 0 && numberB > 0 && numberC > 0)
            {
                Console.WriteLine(signPlus);
            }
            else if (numberA > 0 && numberB < 0 && numberC < 0)
            {
                Console.WriteLine(signPlus);
            }
            else if (numberA < 0 && numberB < 0 && numberC > 0)
            {
                Console.WriteLine(signPlus);
            }
            else if (numberA < 0 && numberB > 0 && numberC < 0)
            {
                Console.WriteLine(signPlus);
            }
            else
            {
                Console.WriteLine(signMinus);
            }
        }
    }
}//posibillity of second solution with array and method is not allowed by the rules