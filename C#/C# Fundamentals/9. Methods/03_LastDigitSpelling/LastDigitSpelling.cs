using System;
using System.Linq;

class LastDigit
{
    static void Main(string[] args)
    {
        //Write a method that returns the last digit of given integer as an English word. 
        //Examples: 512  "two", 1024  "four", 12309  "nine".

        Console.Write("Input number ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        //test method
        Console.WriteLine( LastDigitSpelling(number) );
    }

    public static string LastDigitSpelling(int number)
    {
        string[] digits = {"zero",
                           "one",
                           "two",
                           "three",
                           "four",
                           "five",
                           "six",
                           "seven",
                           "eight",
                           "nine"};

        int last = number % 10;

        return digits[last];
    }
}

