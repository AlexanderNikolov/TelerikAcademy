namespace TAonline.CSharp.ConditionalStatements.Homework5
{
    using System;

    /// <summary>
    /// Sort 3 real values in descending order using nested if statements.
    /// </summary>
    class Task4
    {
        static void Main()
        {
            int a = 1; //test here with values
            int b = 2;
            int c = 3;

            if (a >= b && a >= c)
            {
                if (b > c)
                {
                    PrintNumbers(a, b, c);
                }
                else
                {
                    PrintNumbers(a, c, b);
                }
            }
            else if (b >= a && b >= c)
            {
                if (a > c)
                {
                    PrintNumbers(b, a, c);
                }
                else
                {
                    PrintNumbers(b, c, a);
                }
            }
            else if (c >= a && c >= b)
            {
                if (b > a)
                {
                    PrintNumbers(c, b, a);
                }
                else
                {
                    PrintNumbers(c, a, b);
                }
            }
        }

        static void PrintNumbers(int x, int y, int z)
        {
            Console.WriteLine("Sorted in descending order - {0}, {1}, {2}", x, y, z);
        }
    }
}