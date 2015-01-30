/*
 * Write a program that reads two dates in the format: day.month.year 
 * and calculates the number of days between them. 
 *      Example:
 *  Enter the first date: 27.02.2006
 *  Enter the second date: 3.03.2006
 *  Distance: 4 days
 */
namespace _16_DaysBetweenDates
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first date (dd.mm.yyyy): ");
            var inputDate1 = Console.ReadLine().Split(new char[]{'.', ' ', ':', ',', '-'});
            Console.Write("Enter the second date (dd.mm.yyyy): ");
            var inputDate2 = Console.ReadLine().Split(new char[] { '.', ' ', ':', ',', '-' });

            var firstDate = new DateTime(
                int.Parse(inputDate1[2]),
                int.Parse(inputDate1[1]),
                int.Parse(inputDate1[0])
            );

            var secondDate = new DateTime(
                int.Parse(inputDate2[2]),
                int.Parse(inputDate2[1]),
                int.Parse(inputDate2[0])
            );

            TimeSpan daySum = secondDate - firstDate;
            int result = Math.Abs(daySum.Days);

            Console.WriteLine("Distance: {0} days", result);

            //var firstDate = DateTime.Parse(inputDate1, CultureInfo.InvariantCulture);
        }
    }
}
