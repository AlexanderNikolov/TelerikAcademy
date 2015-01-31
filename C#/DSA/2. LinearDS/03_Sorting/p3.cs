/*
 * Write a program that reads a sequence of integers
 * (List<int>) ending with an empty line and sorts
 * them in an increasing order.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    class Sorting
    {
        static void Main(string[] args)
        {
            List<int> example = new List<int>() { 4, 2, 3, 5, 1 };
            //TODO data reader from file

            example.Sort();
            Console.Write("{ " + string.Join(", ", example) + " }\n" );
        }
    }
}
