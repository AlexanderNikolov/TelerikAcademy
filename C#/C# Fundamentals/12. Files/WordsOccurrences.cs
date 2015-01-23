using System;
using System.Linq;
using System.IO;

class WordsTestResultProgram
{
    static void Main(string[] args)
    {
        //Write a program that reads a list of words from a file words.txt 
        //and finds how many times each of the words is contained in another 
        //file test.txt. The result should be written in the file result.txt 
        //and the words should be sorted by the number of their occurrences 
        //in descending order. Handle all possible exceptions in your methods

        string pathIn = "test.txt";
        string pathWords = "words.txt";
        string pathOut = "result.txt";

        try {
            CollectWordsFromFile(pathWords);
            WordOccureCounter(pathIn, pathOut);
        }
        catch (FileNotFoundException) {
            throw new ArgumentException("File not found! Check path or name.");
        }
        catch (PathTooLongException) {
            throw new ArgumentException("Path too long!");
        }
        //TODO: more exceptions
    }

    static Dictionary<string, int> words = new Dictionary<string, int>();

    static void CollectWordsFromFile(string path)
    {
        using (StreamReader input = new StreamReader(path))
        {
            while (!input.EndOfStream)
            {
                string[] temp = 
                            input.ReadLine()
                            .Split(new char[] { ' ', ',', '\n' }
                            ,StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < temp.Length; i++)
                    words.Add(temp[i], 0); //now have words in dict.Key and go count ocurrences!
            }
        }
    }

    static void WordOccureCounter(string pathIn, string pathOut)
    {
        string test = string.Empty;

        using (var result = new StreamWriter(pathOut))
        using (var reader = new StreamReader(pathIn))
        {
            test = reader.ReadToEnd(); //replace with line by line processing if working with big files!
            for (int i = 0; i < words.Count; i++)
            {
                KeyValuePair<string, int> word = words.ElementAt(i);
                int index = test.IndexOf(word.Key);

                while (index != -1)
                {
                    words[word.Key]++;
                    index = test.IndexOf(word.Key, index + 1);
                }
            }
            
            foreach (KeyValuePair<string, int> entry in words.OrderByDescending(key => key.Value))
                result.WriteLine(entry.Key + " " + entry.Value);
        }
    }
}
