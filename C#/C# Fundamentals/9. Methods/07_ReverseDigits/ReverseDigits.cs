using System;
using System.Linq;

class ReverseDigits
{
    static void Main(string[] args)
    {
        //Write a method that reverses the digits of given decimal number. Example: 256  652

        Console.WriteLine("Input number ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);

        ReverseNumberDigits(number);
    }

    public static void ReverseNumberDigits(int number)
    {
        string result = "";
        int len = number.ToString().Length;

        for (int index = 0; index < len; index++)
        {
            result += number.ToString()[len - index - 1];
        }

        Console.WriteLine(result);
    }
}

