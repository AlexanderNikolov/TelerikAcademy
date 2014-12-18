/*
 * Write a program that finds all prime numbers in the range [1...10 000 000]. 
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class EratosthenesSieve
    {
        static void Main(string[] args)
        {
            // Build Sieve Of Eratosthenes (with little improves by me :))
            Console.WriteLine("Build sieve of Eratosthenes for array with 100 000 000 positions!.");
            Console.Write("Working ...");
            const int Size = 100000000;

            bool[] sieve = new bool[Size]; //all false by default!

            for (int primeCandidate = 2; primeCandidate <= (int)Math.Sqrt(Size); primeCandidate++)
            {
                if (sieve[primeCandidate] == false)
                {
                    // It is prime, so remove all future factors...
                    for (int nonPrime = 2 * primeCandidate; nonPrime < Size; nonPrime += primeCandidate)
                    {
                        sieve[nonPrime] = true;
                    }
                }
            }

            Console.WriteLine("\n\nOutput first primes for algorithm check");

            for (int i = 2; i < 20; i++)
            {
                if (sieve[i] == false)
                    Console.Write(i + " ");
            }
        }
    }
}