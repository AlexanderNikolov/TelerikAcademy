﻿/*
 * You are given a text. Write a program that changes the text in all regions 
 * surrounded by the tags <upcase> and </upcase> to uppercase. 
 * The tags cannot be nested. 
 */
namespace _05_TagsTEXT
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            //input from bgcoder
            //string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string input = Console.ReadLine();
            //end of input
            
            input = (Regex.Replace(input, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));

            Console.WriteLine(input);
        }
    }
}
