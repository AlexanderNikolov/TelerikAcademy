using System;
using System.Linq;

class PolinomialsAlgebra
{
    static void Main(string[] args)
    {
        //Extend the program to support also subtraction and multiplication of polynomials.

         //hard case - different size
        int[] polinomA = { 1, 2, 1 };           //represent x^2 + 2*x + 1
        int[] polinomB = { 2, -4, -1, 1};   //represent 2*x^3 - 4x^2 - x  + 1

        //test (2, 0, -7, -5, 1, 1)
        //zero coefficient mean missing of power x^4 in final results
        Console.WriteLine(string.Join(", ", PolinomialMultiplication(polinomA, polinomB)));


    }
    static int[] PolinomialAdd(int[] x, int[] y)
    {
        int length = Math.Max(x.Length, y.Length);
        int step = (Math.Min(x.Length, y.Length));
        int[] result = new int[length];

        if (step == x.Length)        {
            
            for (int i = 0; i < length; i++)            {

                result[i] = (i >= length - step) ? y[i] + x[i - (length - step)] : y[i];
            }
        }
        else        {
            
            for (int i = 0; i < length; i++)            {

                result[i] = (i >= length - step) ? x[i] + y[i - (length - step)] : x[i];
            }
        }
        return result;
    }
     static int[] PolinomialSub(int[] x, int[] y)
    {
        int length = Math.Max(x.Length, y.Length);
        int step = (Math.Min(x.Length, y.Length));
        int[] result = new int[length];

        if (step == x.Length)        {
            
            for (int i = 0; i < length; i++)            {

                result[i] = (i >= length - step) ? y[i] - x[i - (length - step)] : y[i];
            }
        }
        else        {
            
            for (int i = 0; i < length; i++)            {

                result[i] = (i >= length - step) ? x[i] - y[i - (length - step)] : x[i];
            }
        }
        return result;
    }
     static int[] PolinomialMultiplication(int[] x, int[] y)
    {
        int length = x.Length + y.Length - 1;
        int[] result = new int[length];

        for (int i = 0; i < x.Length; i++)
        {
            for (int j = 0; j < y.Length; j++)
            {
                int power = i + j;
                result[power] += x[i] * y[j]; 
            }
        }

        return result;
    }
}

