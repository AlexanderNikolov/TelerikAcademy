/*
 * Write a program that converts a string to a sequence of C# Unicode character literals. 
 * Use format strings.
 */
namespace _10_StringConverting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string example = "Hi!"; //expected output: \u0048\u0069\u0021

            var output = StringConvertor(example);
            Console.WriteLine(output);

        }

        private static string StringConvertor(string text)
        {
            var result = new StringBuilder();
            foreach (var item in text)
            {
                result.Append(String.Format("\\u{0:X4}", Convert.ToUInt16(item)));
            }

            return result.ToString();
        }
    }
}
