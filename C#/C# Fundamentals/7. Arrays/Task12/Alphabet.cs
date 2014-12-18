/*
 * Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class AlphabetChars
    {
        const int EnglishAlphabetLenght = 26;

        static void Main(string[] args)
        {
            char[] alphabet = new char[EnglishAlphabetLenght * 2];

            for (int ii = 0; ii < EnglishAlphabetLenght; ii++)
            {
                alphabet[ii] = (char)(ii + 65); //capital letters in ASCII table
                alphabet[ii + EnglishAlphabetLenght] = (char)(ii + 97);
            }

            //Console.WriteLine(string.Join(", ", alphabet));
            //A, B, C .. a, b, c ..

            Console.Write("Type random word on English: ");
            var word = Console.ReadLine();
            foreach (var letter in word)
            {
                //variant with CompareTo (string method)
                for (int jj = 0; jj < EnglishAlphabetLenght * 2; jj++)
                {
                    if (letter.CompareTo(alphabet[jj]) == 0)
                    {
                        Console.WriteLine("Char {0} found at index {1}",letter, jj);
                        break;
                    }
                }

                //variant with IndexOf (array method)
                //Console.WriteLine("Char {0} at index {1} ", letter, Array.IndexOf(alphabet, letter));
            }
        }
    }
}
