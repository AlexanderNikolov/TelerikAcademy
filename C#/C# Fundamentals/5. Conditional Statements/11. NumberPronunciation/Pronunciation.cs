namespace TAonline.CSharp.ConditionalStatements.Homework5
{
    using System;

    /// <summary>
    /// * Write a program that converts a number in the range [0...999] to a text corresponding 
    /// to its English pronunciation. Examples:
    /// 0  "Zero"
    /// 273  "Two hundred seventy three"
    /// 400  "Four hundred"
    /// 501  "Five hundred and one"
    /// 711  "Seven hundred and eleven"
    /// </summary>
    class Pronunciation
    {
        static void Main()
        {
            int p100, p10, p1;
            string h100 = " hundred and ";

            Console.Write("Enter number (0-999) ");
            int number = int.Parse(Console.ReadLine());

            p100 = number / 100;
            p10 = (number / 10) % 10;
            p1 = number % 10;

            string[] names = { "zero",
                               "one", 
                               "two", 
                               "three", 
                               "four", 
                               "five", 
                               "six", 
                               "seven", 
                               "eight", 
                               "nine"};

            string[] names2 = { " ",
                                "eleven", 
                                "twelve", 
                                "thirteen", 
                                "fourteen", 
                                "fifteen", 
                                "sixteen", 
                                "seventeen", 
                                "eighteen", 
                                "nineteen"};

            string[] add = { " ",
                             "ten",
                             "twenty", 
                             "thirty", 
                             "forty", 
                             "fifty", 
                             "sixty", 
                             "seventy", 
                             "eighty", 
                             "ninety"};

            if (p100 != 0)
            {
                if (p1 == 0 && p10 != 0)
                {
                    Console.WriteLine(names[p100] + h100 + add[p10]);
                }
                else if (p1 != 0 && p10 == 1)
                {
                    Console.WriteLine(names[p100] + h100 + names2[p1]);
                }
                else if (p1 == 0 && p10 != 0)
                {
                    Console.WriteLine(names[p100] + h100 + add[p10]);
                }
                else if (p10 == 0)
                {
                    if (p1 == 0)
                    {
                        Console.WriteLine(names[p100] + " hundred");
                    }
                    else
                    {
                        Console.WriteLine(names[p100] + h100 + names[p1]);
                    }
                }
                else if (p1 != 0 && p10 != 0)
                {
                    Console.WriteLine(names[p100] + h100 + add[p10] + " " + names[p1]);
                }
            }
            else
            {
                if (p1 == 0 && p10 != 0)
                {
                    Console.WriteLine(add[p10]);
                }
                else if (p1 != 0 && p10 == 1)
                {
                    Console.WriteLine(names2[p1]);
                }
                else if (p1 == 0 && p10 != 0)
                {
                    Console.WriteLine(add[p10]);
                }
                else if (p10 == 0)
                {
                    Console.WriteLine(names[p1]);
                }
                else if (p1 != 0 && p10 != 0)
                {
                    Console.WriteLine(add[p10] + " " + names[p1]);
                }
            }
        }
    }
}