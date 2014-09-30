namespace TAonline.CSharp.Loops.Homework
{
    using System;

    //Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
    //Use the Euclidean algorithm
    class Task8
    {
        static void Main()
        {
            Console.Write("Input common factor X  "); 
            int commonX = int.Parse(Console.ReadLine());
            Console.Write("Input common factor Y  "); 
            int commonY = int.Parse(Console.ReadLine());
    
            Console.WriteLine(gcdCalc(commonX, commonY));
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
}
