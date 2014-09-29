namespace TAonline.CSharp.OperatorsAndExpressions.Homework3
{
    using System;

    /// <summary>
    /// Write an expression that checks if given positive integer number
    /// (n ≤ 100) is prime. E.g. 37 is prime;
    /// </summary>
    class Task7
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int primeCandidate = int.Parse(Console.ReadLine());

            int limit = (int)(Math.Sqrt(primeCandidate) + 1);     //calc limit for finding primes method

            for (int i = 2; i < limit; i++)
            {
                if (primeCandidate == 2)
                {
                    Console.WriteLine("{0} is not prime!", primeCandidate);
                    break;
                }
                else if (primeCandidate % i == 0)
                {
                    Console.WriteLine("{0} is not prime!", primeCandidate);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} is prime!", primeCandidate);
                }
            }
        }
    }
}