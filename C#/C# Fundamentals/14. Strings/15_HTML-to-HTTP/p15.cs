﻿/*
 * Write a program that replaces in a HTML document given as string all the tags 
 * <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 
 * Sample HTML fragment:
 *      <p>Please visit <a href="http://academy.telerik.com"
 *      >our site</a> to choose a training course. Also visit 
 *      <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
 *      
 *      <p>Please visit [URL=http://academy.telerik. com]
 *      our site[/URL] to choose a training course. Also visit 
 *      [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */
namespace TA2014_Strings_homework
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var example = "<p>Please visit <a href=\"http://academy.telerik.com\"> our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            example = (Regex.Replace(example, "<a href=\"", "[URL="));
            example = (Regex.Replace(example, "</a>", "[/URL]"));
            example = (Regex.Replace(example, "\">", "]"));

            Console.WriteLine(example);
        }
    }
}
