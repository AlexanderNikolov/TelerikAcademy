/*
 * Write a program that downloads a file from Internet 
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the 
 * current directory. Find in Google how to download files in C#. 
 * Be sure to catch all exceptions and to free any used resources in the finally block
 */

namespace TAonlineHomework7exceptions
{
    using System;
    using System.Linq;
    using System.Net;
    using System.IO;

    class WebDownloadProgram
    {
        static void Main(string[] args)
        {
            string url = "http://www.devbg.org/img/Logo-BASD.jpg";

            try
            {
                Console.Write(@"Enter destination path and file name. e.g. C:\windows\win.txt ");
                string pathOut = Console.ReadLine();
                var download = new WebClient();
                download.DownloadFile(new Uri(url), pathOut);
            }
            catch (ArgumentNullException ane)
            {
                ExceptionProcessor(ane);
            }
            catch (WebException we)
            {
                ExceptionProcessor(we);
            }
        }

        private static void ExceptionProcessor(Exception message)
        {
            //TODO Exception message filter
            Console.WriteLine(message);
        }
    }
}
