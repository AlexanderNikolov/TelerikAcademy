namespace TAonline.CSharp.ConditionalStatements.Homework5
{
    using System;

    /// <summary>
    /// Write a program that finds the biggest of three integers using nested if statements.
    /// </summary>
    class Task3
    {
        static void Main()
        {
            Console.WriteLine("biggest number = {0}", BiggestFrom3(3, 3, 5));

        }

        static int BiggestFrom3(int x, int y, int z)
        {
            if ((x >= y && x >= z))
            {
                return x;
            }
            else if ((y >= x && x >= z))
            {
                return y;
            }
            else
            {
                return z;
            }
        }
    }
}