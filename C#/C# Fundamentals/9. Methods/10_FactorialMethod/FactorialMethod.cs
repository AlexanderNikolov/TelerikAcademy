using System;
using System.Linq;
using System.Collections.Generic;

class FactorialMethod
{
    static void Main()
    {
        //if int -> n < 26, if double -> n < 170!!!
        Console.WriteLine("Input n for n! (1<n<170) ");
        string input = Console.ReadLine();
        double numberN = double.Parse(input);

        //test method
        Console.WriteLine(Factorial(numberN));
    }

    static double[] decimalF = null;
    
    static void init_dFactors()
    {
        decimalF = new double[171];
        decimalF[0] = 1;
        double f = 1;
        for (int i = 1; i < 171; i++)        {
            
            f *= i;
            decimalF[i] = f;
        }
    }
    public static double Factorial(double factor)
    {
        init_dFactors();
        if (factor < 0 || factor > 170) 
            throw new OverflowException("Arithmetic operation resulted in an overflow.");
        return decimalF[(int)factor];
    }
}

