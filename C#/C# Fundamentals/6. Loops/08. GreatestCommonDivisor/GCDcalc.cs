using System;

class GCDcalc
{
    static void Main()
    {
        //Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
        //Use the Euclidean algorithm

        Console.Write("Input common factor X  "); 
        int x = int.Parse(Console.ReadLine());
        Console.Write("Input common factor Y  "); 
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine(gcdCalc(x, y));
    }

    public static int gcdCalc(int x, int y)
    {
        if (y == 0)     
        {
            return x;
        }
        else         
        {
            return gcdCalc(y, x % y);   
        }
    }
}
