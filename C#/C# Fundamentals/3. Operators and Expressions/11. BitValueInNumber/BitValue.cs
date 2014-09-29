namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Write an expression that extracts from a given integer i 
    /// the value of a given bit number b. 
    /// Example: i=5; b=2  value=1.
    /// </summary>
    class Task11
    {
        static void Main()
        {
            int i, b;
            int mask;

            Console.Write("Enter number: "); 
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position: "); 
            b = int.Parse(Console.ReadLine());

            mask = (1 << b);   //made mask for bitwise operations

            if ((i & mask) == mask)
            {
                Console.WriteLine("i={0}; b={1} value=1", i, b);
            }
            else
            {
                Console.WriteLine("i={0}; b={1} value=0", i, b);
            }
        }
    }
}