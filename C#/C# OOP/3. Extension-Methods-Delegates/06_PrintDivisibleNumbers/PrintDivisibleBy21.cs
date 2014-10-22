/*
 * 6. Write a program that prints from given array of integers all numbers 
 * that are divisible by 7 and 3. Use the built-in extension methods and 
 * lambda expressions. Rewrite the same with LINQ.
 */

namespace PrintDivisibleNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PrintDivisibleBy21
    {
        public static void Main()
        {
            //init data
            const int Special = 3*7;
            var numbers = new[] { 5, 8, 21, 42, 49, 56, 90, 115 };

            //lambda expression
            var lambdaExp = numbers.Where(num => (num % Special == 0));

            foreach (var item in lambdaExp)
                Console.WriteLine("{0}", item);

            //Linq query
            var linqQuery =
                from number in numbers
                where number % Special == 0
                select number;

            Console.WriteLine();
            foreach (var item in linqQuery)
                Console.WriteLine("{0}", item);
        }
    }
}
