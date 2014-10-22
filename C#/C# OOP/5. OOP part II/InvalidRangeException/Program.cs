/*
 * Define a class InvalidRangeException<T> that holds information about an error condition 
 * related to invalid range. It should hold error message and a range definition [start … end].
 * Write a sample application that demonstrates the InvalidRangeException<int> and 
 * InvalidRangeException<DateTime> by entering numbers in the range [1..100] 
 * and dates in the range [1.1.1980 … 31.12.2013].
 */

using System;
using System.Linq;

class Program
{
   static void Main()
    {
        try
        {
            int mayFirstDay = 1;
            int mayLastDay = 30;

            int newLast = 31;

            if (mayFirstDay < newLast && newLast > mayLastDay)
                throw new InvalidRangeException<int>(mayFirstDay, mayLastDay);
        }
        catch (InvalidRangeException<int> ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("First day of May: {0}, last: {1}", ex.Start, ex.Last);
        }

        Console.WriteLine();

        try
        {
            DateTime academyStart = new DateTime(2013, 9, 30);
            DateTime academyEnd = new DateTime(2014, 8, 31);

            DateTime newAcademyEnd = new DateTime(2014, 12, 31);

            if (academyStart < newAcademyEnd && newAcademyEnd > academyEnd)
                throw new InvalidRangeException<DateTime>(academyStart, academyEnd);
        }
        catch (InvalidRangeException<DateTime> ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Academy 2013 Autumn Start: {0:D}, End: {1:D}", ex.Start, ex.Last);
        }
    }
}
