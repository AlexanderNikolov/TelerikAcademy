namespace TA2013_MultidimensionalArrays_homework
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Matrix matrixOne = new Matrix(2, 2);
            matrixOne[0, 0] = 2;
            matrixOne[0, 1] = -12;

            Matrix matrixTwo = new Matrix(2, 2);
            matrixTwo[0, 0] = 2;
            matrixTwo[1, 1] = 5;

            //test class
            Matrix add = matrixOne + matrixTwo;
            Matrix sub = matrixOne - matrixTwo;
            Matrix multiplication = matrixOne * matrixTwo;

            //output
            Console.WriteLine(add.ToString());
            Console.WriteLine();
            Console.WriteLine(sub.ToString());
            Console.WriteLine();
            Console.WriteLine(multiplication.ToString());
        }
    }
}