/*
 * Write a program that prints to the console which day of the week is today.
 * Use System.DateTime
 */

namespace TA2014_homework_classes
{
    using System;
    using System.Linq;

    class Today
    {
        static void Main(string[] args)
        {
            var day = DateTime.Now;
            Console.WriteLine("Today is {0} ", day.DayOfWeek);
        }
    }
}
