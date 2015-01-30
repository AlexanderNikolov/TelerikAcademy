/*
 * Write a program for extracting all email addresses from given text. 
 * All substrings that match the format <identifier>@<host>…<domain> 
 * should be recognized as emails.
 */
namespace _18_EMailExtraction
{
    using System;
    using System.Linq;
    using System.Net.Mail;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Vote for Metalica on unforgiven@gmail.com";
            string pattern = @"\w+@\w+\.\w+";

            var mail = new MailAddress(Regex.Match(text, pattern).ToString());

            Console.WriteLine("<identifier> {0}\n<host> {1}\n<domain> {2}", 
                mail.User, mail.Host.Split('.')[0], mail.Host.Split('.')[1]);
        }
    }
}
