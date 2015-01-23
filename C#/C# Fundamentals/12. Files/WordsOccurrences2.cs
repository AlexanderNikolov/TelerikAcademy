/*Write a program that reads a list of words from a file 
 * words.txt and finds how many times each of the words 
 * is contained in another file test.txt. The result should 
 * be written in the file result.txt and the words should be 
 * sorted by the number of their occurrences in descending order.
 * Handle all possible exceptions in your methods.
*/

public class ListWordsCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security;
    using System.Text.RegularExpressions;

    public static void Main(string[] args)
    {
        try
        {
            StreamReader inputWords = new StreamReader("../../words.txt");
            StreamReader inputText = new StreamReader("../../test.txt");
            StreamWriter outputResult = new StreamWriter("../../result.txt", false);
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            string line = string.Empty;

            using (inputWords)
            {
                line = inputWords.ReadLine();
                while (line != null)
                {
                    dictionary.Add(line, 0);
                    line = inputWords.ReadLine();
                }
            }

            using (inputText)
            {
                line = inputText.ReadLine();
                List<string> wordList = new List<string>(dictionary.Keys);
                while (line != null)
                {
                    foreach (string word in wordList)
                    {
                        string regex = string.Format("\\b{0}\\b", word);
                        MatchCollection matches = Regex.Matches(line, regex);
                        dictionary[word] += matches.Count;
                    }

                    line = inputText.ReadLine();
                }
            }

            using (outputResult)
            {
                foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                {
                    outputResult.Write(wordCounter.Key);
                    outputResult.Write(": ");
                    outputResult.WriteLine(wordCounter.Value);
                }
            }
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
