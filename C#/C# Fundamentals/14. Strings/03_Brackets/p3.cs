/*
 * Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 */

namespace TA2014_Strings_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            //bgcoder input
            //Console.WriteLine("Enter expression for validation ex: ((a+b)/5-d)");
            var input = Console.ReadLine();
            //end of input

            Console.WriteLine(BracketsValidation(input));
        }

        private static bool BracketsValidation(string input)
        {
            if (input == null || input == string.Empty || input == "()") 
                return false;
            
            var brackets = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')  brackets++;
                else if (input[i] == ')')  brackets--;
            }

            if (brackets != 0) 
                return false;
            else 
                return true;
        } 
    }
}
