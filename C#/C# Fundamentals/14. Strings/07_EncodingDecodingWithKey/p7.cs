/*
 * Write a program that encodes and decodes a string using given encryption key (cipher). 
 * The key consists of a sequence of characters. The encoding/decoding is done by 
 * performing XOR (exclusive or) operation over the first letter of the string with 
 * the first of the key, the second – with the second, etc. When the last key character 
 * is reached, the next is the first.
 */
namespace _07_EncodingDecodingWithKey
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Write a program that encodes and decodes a string using given encryption key";
            string cipher = "key";

            var message = Enigma(text, cipher);
            Console.WriteLine("{0}", message);
            Console.WriteLine("\n{0}", Enigma(message, cipher));
        }

        private static string Enigma(string text, string cipher)
        {
            var result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                result.Append( (char)(text[i] ^ cipher[i % cipher.Length]));
            }

            return result.ToString();
        }
    }
}
