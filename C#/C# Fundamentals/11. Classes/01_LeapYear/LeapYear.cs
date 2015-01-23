/*
 * Write a program that reads a year from the console and checks whether it is a leap.
 * Use DateTime
 */

namespace TA2014_homework_classes
{
    using System;
    using System.Linq;

    class LeapYear
    {
        static void Main(string[] args)
        {
            bool leapYear = DateTime.IsLeapYear(DateTime.Now.Year);

            Console.WriteLine("Is {0} leap year? {1}", DateTime.Now.Year, leapYear);
        }
    }
}
