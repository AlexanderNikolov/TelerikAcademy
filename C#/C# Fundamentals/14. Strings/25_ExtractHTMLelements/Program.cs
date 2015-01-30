/*
 * Write a program that extracts from given HTML file its title (if available), 
 * and its body text without the HTML tags. 
 */
namespace _25_ExtractHTMLelements
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

            var title = Regex.Match(text, "<title>(.*?)</title>");
            var body = Regex.Match(text, "<body>(.*?)</body>");

            Console.WriteLine("[title]\n{0}\n\n[body]", 
                title.Groups[1].ToString());
            foreach (Match item in Regex.Matches(body.ToString(), "(?<=^|>)[^><]+?(?=<|$)")) 
                Console.Write(item + " ");
            Console.WriteLine("\n");

        }
    }
}
