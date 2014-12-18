using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //Write a program that can solve these tasks:
        //Reverses the digits of a number
        //Calculates the average of a sequence of integers
        //Solves a linear equation a * x + b = 0
        //Create appropriate methods.
        //Provide a simple text-based menu for the user to choose which task to solve.
        //Validate the input data:
        //The decimal number should be non-negative
        //The sequence should not be empty
        //a should not be equal to 0

        int choice;
        int sequence;
        int a = 0;
        int b = 0;
        int c = 0;

        while (true)
        {
            Console.WriteLine("Program Menu:");
            Console.WriteLine("1. Reverses the digits of a number");
            Console.WriteLine("2. Calculates the average of a sequence of integers");
            Console.WriteLine("3. Solves a linear equation a * x + b = 0");
            Console.WriteLine();
            Console.Write("Your choice? ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                if (choice == 1 || choice == 2 || choice == 3)
                {
                    Console.Clear();
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("Wrong input, please try again");
            Console.WriteLine();
        }
        switch (choice)
        {
            case 1:
                int number;

                while (true)
                {
                    Console.WriteLine("1. Reverses the digits of a number");
                    Console.WriteLine();
                    Console.Write("Input number ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out number))
                    {
                        ReverseNumberDigits(number);
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input, please try again");
                    Console.WriteLine();
                }
                break;
            case 2:
                while (true)
                {
                    Console.WriteLine("2. Calculates the average of a sequence of integers");
                    Console.WriteLine();
                    Console.Write("Input sequence of integers ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out sequence))
                    {
                        SequenceAverage(sequence);
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input, please try again");
                    Console.WriteLine();
                }
                break;
            case 3:
                while (true)
                {
                    Console.WriteLine("3. Solves a linear equation a * x + b = 0");
                    Console.WriteLine();
                    Console.Write("Input coefficient a ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out a))
                    {
                        if (a != 0)
                            goto case 4;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input, please try again");
                    Console.WriteLine();
                }
            case 4:
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Input coefficient b ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out b))
                    {
                        SolveEquation(a, b);
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input, please try again");
                    Console.WriteLine();
                }
                break;
        }
    }
    //todo: reverse digits
    public static void ReverseNumberDigits(int number)
    {
        string result = "";
        int len = number.ToString().Length;

        for (int index = 0; index < len; index++)
            result += number.ToString()[len - index - 1];

        Console.WriteLine();
        Console.WriteLine("Your result {0}", result);
    }

    //todo: Calculates the average of a sequence of integers
    public static void SequenceAverage(int sequence)
    {
        double result = 0;
        if (sequence < 0)
            sequence = -sequence;

        int length = sequence.ToString().Length;

        for (int i = 0; i < length; i++)
        {
            result += sequence % 10;
            sequence /= 10;
        }

        result /= length;
        Console.WriteLine();
        Console.WriteLine(result);
    }

    //todo: Solves a linear equation a * x + b = 0
    public static void SolveEquation(int a, int b)
    {
        double root1 = 0;
        Console.WriteLine();

        root1 = (-b / (double)a);
        Console.WriteLine("x = {0:F}", root1);
    }
}

