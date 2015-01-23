/*
 * Write a program that extracts from given XML file all the text without the tags. 
 * Example:
 *      <?xml version="1.0">
 *          <student>
 *              <name>Pesho</name>
 *              <age>21</age>
 *              <interests count="3">
 *                  <interest>Games</instrest>
 *                  <interest>C#</instrest>
 *                  <interest>Java</instrest>
 *              </interests>
 *          </student>
 */

namespace _10_RemoveXMLTags
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.IO;
    using System.Xml;

    class p10
    {
        static void Main(string[] args)
        {
            string path = "test.xml";

            using (var reader = new StreamReader(path))
            {
                string pattern = ">[^<]*</";
                string match;
                while (!reader.EndOfStream)
                {
                    foreach (Match item in Regex.Matches(reader.ReadLine(), pattern))
                    {
                        match = item.Value.ToString();
                        match = match.Remove(match.Length - 2, 2);
                        match = match.Remove(0, 1);

                        if (!string.IsNullOrWhiteSpace(match))
                            Console.WriteLine(match);
                    }
                }
            }
        }
    }
}