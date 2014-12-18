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
            char[] abcd = { 'a', 'b', 'c', 'd' };
            char[] abad = { 'a', 'b', 'a', 'd' };
            char[] abc = { 'a', 'b', 'c' };

            ArrayComparer(abc, abc);
            ArrayComparer(abc, abcd);
            //ArrayComparer(abcd, abad);
            //ArrayComparer(abc, abad);

        }

        static void ArrayComparer(char[] a, char[] b)
        {
            int len = (a.Length > b.Length) ? b.Length : a.Length;
            bool compareArrays = false;
            bool equal = true;

            for (int index = 0; index < len; index++)
            {
                if (a[index] == b[index])
                {
                    continue;
                }
                if (a[index] < b[index])
                {
                    compareArrays = true;
                    equal = false;
                    break;
                }
            }

            if (equal)
                Console.WriteLine("Arrays are indentical\n");
            else if (!compareArrays)
                Console.WriteLine("Through index {0}, first array is lexicographically first\n", len);
            else
                Console.WriteLine("Through index {0}, second array is lexicographically first\n", len);
        }
    }
}