/*
 * Write a program that extracts from a given text all dates that match 
 * the format DD.MM.YYYY. Display them in the standard date format for Canada.
 */
namespace _19_ExtractDates
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lincoln was shot on 23.02.1874";
            string pattern = @"\b\d{2}.\d{2}.\d{4}\b";

            var date = Regex.Match(text, pattern).ToString();

            Console.WriteLine(
                DateTime.Parse(date)
                        .ToString("dddd MM.dd.yyyy", new CultureInfo("fr-CA")));
        }
    }
}