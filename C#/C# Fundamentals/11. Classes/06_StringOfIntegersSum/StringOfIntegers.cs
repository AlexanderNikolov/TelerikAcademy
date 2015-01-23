/*
 * You are given a sequence of positive integer values written into a
 * string, separated by spaces. Write a function that reads these values 
 * from given string and calculates their sum. 
 * Example: string = "43 68 9 23 318"  result = 461
 */

namespace TA2014_homework_classes
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = "43 68 9 23 318";

            Console.WriteLine(IntegersSum(input));
        }
        
        static long IntegersSum(string input)
        {
            long sum = 0;
            foreach (var item in input.Split(' '))  
                sum += int.Parse(item);
            
            return sum;
        }
    }
}
