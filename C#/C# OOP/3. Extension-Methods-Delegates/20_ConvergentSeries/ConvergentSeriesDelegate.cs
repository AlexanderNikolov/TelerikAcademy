/*
 * By using delegates develop an universal static method to calculate the sum of infinite convergent series 
 * with given precision depending on a function of its term. By using proper functions for the term calculate 
 * with a 2-digit precision the sum of the infinite series:
 * 	1 + 1/2 + 1/4 + 1/8 + 1/16 + …
 * 	1 + 1/2! + 1/3! + 1/4! + 1/5! + …
 * 	1 + 1/2 - 1/4 + 1/8 - 1/16 + … 
 */

using System;
using System.Collections.Generic;
using System.Linq;

class ConvergentSeriesDelegate
{
    static void Main()
    {
        //1 + 1/2 + 1/4 + 1/8 + 1/16 + …
        Console.WriteLine(ConvergentSum(n => 1 / Math.Pow(2, n - 1), 0.01));

        //1 + 1/2! + 1/3! + 1/4! + 1/5! + …
        Console.WriteLine(ConvergentSum(n => 1 / FactorialCalc(n - 1), 0.01));

        //1 + 1/2 - 1/4 + 1/8 - 1/16 + … 
        Console.WriteLine(ConvergentSum(n => 1 / FractionSign(n) * Math.Pow(2, n - 1), 0.01));

    }

    //delegate
    public static double ConvergentSum(Func<int, double> termValue, double precision)
    {
        return Enumerable.Range(1, int.MaxValue)
                         .Select(termValue)
                         .TakeWhile(term => term >= precision)
                         .Sum();
    }

    static int FactorialCalc(int number)
    {
        if (number == 0) 
            return 1;

        int factorial = 1;
        while (true)  
        {
            if (number <= 1)
                break;
            
            factorial *= number;
            number--;
        }

        return factorial;
    }

    static int FractionSign(int number)
    {
        if (number == 1) 
            return 1;
        return (number % 2 == 0 ? 1 : -1);
    }
}

