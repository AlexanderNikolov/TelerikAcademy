/*
 * Write a program that parses an URL address given in the format:
 *  [protocol]://[server]/[resource]
 * and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
 */
namespace _12_UrlParser
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string input = "http://www.devbg.org/forum/index.php";
            var url = new Uri(input);

            Console.WriteLine(UrlProtocolParser(input));
            Console.WriteLine(url.Authority);
            Console.WriteLine(url.AbsolutePath);
        }

        private static string UrlProtocolParser(string url)
        {
            var result = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                if (url[i] == ':') break;
                result.Append(url[i]);
            }

            return result.ToString();
        }
    }
}
