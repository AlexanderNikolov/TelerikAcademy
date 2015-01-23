/*
 * Write a program that removes from a text file all words 
 * listed in given another text file. 
 * Handle all possible exceptions in your methods.
 */

namespace _12_RemoveBadWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.IO;

    class p12
    {
        static void Main(string[] args)
        {
            var path = "../../bad_words_list.txt";
            var path2 = "../../sample.txt";
            var path3 = "../../result.txt";

            try
            {
                BadWordsRemover(path2, path3, path);
            }
            catch (ArgumentNullException argnull)
            {
                ExceptionProcessor(argnull);   
            }
            catch (FileNotFoundException fnf)
            {
                ExceptionProcessor(fnf);
            }
            catch (DirectoryNotFoundException dirErr)
            {
                ExceptionProcessor(dirErr);
            }
        }

        private static void BadWordsRemover(string pathIN, string pathOUT, string path)
        {
            var input = new StreamReader(pathIN);
            var output = new StreamWriter(pathOUT);
            var blacklisted = GetBadWords(path);

            using (input)
            using(output)
            {
                while (!input.EndOfStream)
                {
                    var line = input.ReadLine();
                    foreach (var word in blacklisted)
                    {
                        var pattern = "\\b" + word + "\\b";
                        line = Regex.Replace(line, pattern, string.Empty);
                    }

                    output.WriteLine(line);
                }
            }
        }

        private static string[] GetBadWords(string path)
        {
            var input = new StreamReader(path);
            using (input)
            {
                string[] badWords = input.ReadToEnd()
                    .Split(new char[] { ' ', ',', '.', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                return badWords;
            }
        }

        private static void ExceptionProcessor(Exception message)
        {
            Console.WriteLine(message);
        }
    }
}
