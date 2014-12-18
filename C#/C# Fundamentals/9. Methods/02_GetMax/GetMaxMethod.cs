/*
 * Write a method GetMax() with two parameters that returns the bigger 
 * of two integers. Write a program that reads 3 integers from the console 
 * and prints the biggest of them using the method GetMax().
 */

namespace TA2013_CSharp_Methods_homework
{
    using System;

    class GetMaxMetod
    {
        static void Main(string[] args)
        {
            int numberA, 
                numberB, 
                numberC;

            Console.Write("Input first number: ");
            numberA = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            numberB = int.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            numberC = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe biggest number is {0}", GetMax(GetMax(numberA, numberB), numberC));
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            return (firstNumber > secondNumber) ? firstNumber : secondNumber;
        }
    }
}