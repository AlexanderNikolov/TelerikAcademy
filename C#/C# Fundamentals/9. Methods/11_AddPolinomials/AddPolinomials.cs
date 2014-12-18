using System;
using System.Linq;

class AddPolinomials
{
    static void Main(string[] args)
    {
        //Write a method that adds two polynomials. Represent them as arrays 
        //of their coefficients as in the example below:
        //x2 + 5 = 1x2 + 0x + 5 

        //hard case - different size
        int[] polinomA = { 1, 2, 1 };           //represent x^2 + 2*x + 1
        int[] polinomB = { 2, -4, -1, 1, 1 };   //represent 2*x^4 - 4x^3 - x^2 + x + 1

        //test (2, -4, 0, 3, 2)
        Console.WriteLine(string.Join(", ", PolinomialSum(polinomA, polinomB)));

    }

    static int[] PolinomialSum(int[] x, int[] y)
    {
        int length = Math.Max(x.Length, y.Length);
        int step = (Math.Min(x.Length, y.Length));
        int[] result = new int[length];

        if (step == x.Length)
        {
            for (int i = 0; i < length; i++)
            {

                result[i] = (i >= length - step) ? y[i] + x[i - (length - step)] : y[i];
            }
        }
        else
        {
            for (int i = 0; i < length; i++)
            {

                result[i] = (i >= length - step) ? x[i] + y[i - (length - step)] : x[i];
            }
        }


        return result;
    }
}

