/*
 * Write a program that generates and prints to the console 
 * 10 random values in the range [100, 200]
 */

namespace TA2014_homework_classes
{
    using System;
    using System.Linq;

    class RandomValues
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++) 
                Console.WriteLine(rnd.Next(100, 200));
        }
    }
}
