namespace TAonline.CSharp.Loops.Homework
{
    using System;

    /// <summary>
    /// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
    /// </summary>
    class MoreFactorials
    {
        static void Main()
        {
            Console.Write("Input number K (1 .. 25)  "); 
            int numberK = int.Parse(Console.ReadLine());
            Console.Write("Input number N, where  1 < N < K)  "); 
            int numberN = int.Parse(Console.ReadLine());

            int denominator = numberK - numberN;
            Console.WriteLine("N!*K! / (K-N)! = {0}", 
                (factorialCalc(numberN) * factorialCalc(numberK)) / factorialCalc(denominator));
        }

        static long factorialCalc(int number)    
        {
            return number <= 1 ? 1 : number * factorialCalc(number - 1);
        }
    }
}