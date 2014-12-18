/*
 * Write a method that asks the user for his name and prints “Hello, <name>”
 * (for example, “Hello, Peter!”). Write a program to test this method.
 */

namespace TA2013_CSharp_Methods_homework
{
    using System;
    using System.Linq;

    class FirstMethod
    {
        static void Main(string[] args)
        {
            Hello();
        }

        static void Hello()
        {
            Console.Write("Input your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!",  name );
        }
    }
}