namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// We are given integer number n, value v (v=0 or 1) and a position p.
    /// Write a sequence of operators that modifies n to hold the value v
    /// at the position p from the binary representation of n.
    /// Example: n = 5 (00000101), p=3, v=1  13 (00001101)
    ///          n = 5 (00000101), p=2, v=0  1 (00000001)
    /// </summary>
    class Task12
    {
        static void Main()
        {
            int n, p, v;
            int maskY, maskYY;

            Console.Write("Enter number N: "); 
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position: "); 
            p = int.Parse(Console.ReadLine());
            Console.Write("Enter value for check (0 or 1): "); 
            v = int.Parse(Console.ReadLine());

            maskY = (1 << p); //made mask 
            maskYY = ~((1 << p)); //made ~mask

            if (v == 1)
            {
                int result = (n | maskY);
                Console.Clear();
                Console.Write("n = {0}, p = {1} v = {2} ? ", n, p, v);
                Console.WriteLine(result.ToString());
            }
            else
            {
                int result = (n & maskYY);
                Console.Clear();
                Console.Write("n = {0}, p = {1} v = {2} ? ", n, p, v);
                Console.WriteLine(result.ToString());
            }
        }
    }
}