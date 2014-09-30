namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// Write a program that calculates N!/K! for given N and K (1<K<N).
    /// </summary>
    class DivideFactorials
    {
        static void Main()
        {
            int numberN, numberK;
            decimal factorialN = 1;
            decimal factorialK = 1;

            Console.Write("Input number N for end of sequence 1 .. N (1-25):  "); 
            numberN = int.Parse(Console.ReadLine());
            Console.Write("\nInput number K for end of sequence 1 .. K, where 1<K<N:  "); 
            numberK = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numberN; i++) //start from 2 (N! and K! already have value)
            {
                factorialN *= (decimal)i;
                factorialK *= (decimal)((i > numberK) ? 1 : i);
            }

            Console.WriteLine("\nN! / K! = {0}", factorialN / factorialK);
        }
    }
}