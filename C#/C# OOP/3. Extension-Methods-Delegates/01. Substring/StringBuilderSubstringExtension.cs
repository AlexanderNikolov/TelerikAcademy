/*
 * 1. Implement an extension method Substring(int index, int length)
 * for the class StringBuilder that returns new StringBuilder and
 * has the same functionality as Substring in the class String.
 */

namespace Substring
{
    using System;
    using System.Text;

    public static class StringBuilderSubstringExtension
    {
        //substitute StringBuilder with dynamic for fun only 
        public static dynamic Substring (this StringBuilder source, int startIndex, int length)
        {
            if (startIndex < 0 || length < 0 || startIndex + length > source.Length)
                throw new ArgumentException();

            var result = new StringBuilder();
            for (int i = startIndex; i < startIndex + length; i++)
                result.Append(source[i]);

            return result;
        }
    }   

    class StringBuilderSubstringExtensionTest
    {
        static void Main(string[] args)
        {
            var output = new StringBuilder();

            output.Append("Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            //test here
            Console.WriteLine(output.Substring(0, 12));
        }
    }
}
