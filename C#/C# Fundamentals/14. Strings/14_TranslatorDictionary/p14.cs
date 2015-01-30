/*
 * A dictionary is stored as a sequence of text lines containing words 
 * and their explanations. Write a program that enters a word and translates 
 * it by using the dictionary. 
 */
namespace _14_TranslatorDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string path = "dictionary.txt";
            Console.Write("Please enter word for translation (.NET, CLR, namespaces) ");
            string input = Console.ReadLine();
            
            var collection = DictReader(path);
            Console.WriteLine(collection[input]);
        }

        private static Dictionary<string, string> DictReader(string path)
        {
            var dict = new Dictionary<string, string>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split('-');
                    string key = line[0].TrimEnd();
                    string value = line[1].TrimStart();
                    if (key != "" || key != null)
                    {
                        dict.Add(key, value);    
                    }
                }
            }
            return dict;
        }
    }
}
