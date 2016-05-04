/*
 * Write a program that compares two char arrays lexicographically (letter by letter).
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;

    class Task3
    {
        static void Main(string[] args)
        {
            string charArr1asString = Console.ReadLine();
            string charArr2asString = Console.ReadLine();

            var firstArray = charArr1asString.ToCharArray();
            var secondArray = charArr2asString.ToCharArray();

            ArrayComparer(firstArray, secondArray);
        }

        static char smallLetterToCapital(char ch)
        { // check for small english or cyrillic letter and returns corresponding capital letter, else return same symbol
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'а' && ch <= 'я'))
                return Convert.ToChar(ch - 32);
            else
                return ch;
        }

        static void ArrayComparer(char[] firstArray, char[] secondArray)
        { //TODO exclude printing of results in separate method

            int length = (firstArray.Length > secondArray.Length) ? secondArray.Length : firstArray.Length;

            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine(">");
            }
            else if (firstArray.Length == secondArray.Length)
            {
                bool equal = true;

                for (int i = 0; i < length; i++)
                {
                    char ch1 = smallLetterToCapital(firstArray[i]);
                    char ch2 = smallLetterToCapital(secondArray[i]);

                    if (ch1 > ch2 && equal == true)
                    {
                        Console.WriteLine(">");
                        equal = false;
                        break;
                    }
                    else if (ch2 > ch1 && equal == true)
                    {
                        Console.WriteLine("<");
                        equal = false;
                        break;
                    }
                }

                if (equal)
                    Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine("<");
            }
        }
    }
}
