/*
 * Write a program that reads a date and time given in the format: 
 * day.month.year hour:minute:second and prints the date and time after 
 * 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

 */
namespace _17_DateTimePlus
{
    using System;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date and time (day.month.year hour:minute:second): ");
            string dateString = Console.ReadLine();
            var provider = new System.Globalization.CultureInfo("bg-BG");

            try
            {
                var date = DateTime.Parse(dateString, provider);
                var result = date.AddHours(6).AddMinutes(30);
                Console.WriteLine("{0, 76}", result.ToString("dddd dd.MM.yyyy HH:mm:ss", provider));
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format.", dateString);
            } 
        }
    }
}
