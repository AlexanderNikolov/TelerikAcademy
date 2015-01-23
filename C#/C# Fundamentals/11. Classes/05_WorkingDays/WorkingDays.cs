/*
 * Write a method that calculates the number of workdays between 
 * today and given date, passed as parameter. Consider that workdays
 * are all days from Monday to Friday except a fixed list of public 
 * holidays specified preliminary as array
 */

namespace TA2014_homework_classes
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            //test here
            var then = new DateTime(2014, 5, 14);
            var today = DateTime.Today;
            
            TimeSpan daySum = today - then;
            int days = daySum.Days;
            int count = 0;

            for (double i = 1; i < days; i++)
            {
                var day = today.AddDays(i);
                if (WorkingDays(day)) 
                    count++;
            }
            //output
            Console.WriteLine(count);
        }

        static bool WorkingDays(DateTime day)
        {
            const string saturday = "Saturday";
            const string sunday = "Sunday";

            foreach (var dayOff in hollidays)
            {
                if (day == dayOff ||
                    day.DayOfWeek.ToString() == saturday ||
                    day.DayOfWeek.ToString() == sunday)
                {
                    return false;
                }
            }

            return true;
        }

        //please update for future tests!
        static DateTime[] hollidays = { new DateTime(2014, 12, 23),
                                        new DateTime(2014, 12, 24),
                                        new DateTime(2014, 12, 25),
                                        new DateTime(2014, 12, 26),
                                        new DateTime(2014, 12, 31),
                                        new DateTime(2014, 1, 1),
                                        new DateTime(2014, 3, 3),
                                        new DateTime(2014, 4, 18),
                                        new DateTime(2014, 4, 19),
                                        new DateTime(2014, 4, 20),
                                        new DateTime(2014, 5, 1),
                                        new DateTime(2014, 5, 6)   
        };
    }
}
