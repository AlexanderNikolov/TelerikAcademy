namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// 5.Write a program that gets two numbers from the console and prints the greater of them. 
    /// dont use if statements!
    /// </summary>
    class Task5
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter integer number: ");
            int numberB = int.Parse(Console.ReadLine());

            int greater = numberA > numberB ? numberA : numberB;
            Console.WriteLine(greater);
        }
    }
}