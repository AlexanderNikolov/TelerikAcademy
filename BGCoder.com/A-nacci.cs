// ----------------------------------------------
//
// 		taks from www.BGCoder.com
//
//-----------------------------------------------

using System;
using System.Linq;

class Solver
{
    static void Main(string[] args)
    {
        //input
        char firstValue = 
            char.Parse(Console.ReadLine());
        char secondValue = 
            char.Parse(Console.ReadLine());
        int numberL = 
            int.Parse(Console.ReadLine());

        //output and logic
        if (numberL != 1)
        {
            char sum;
            //first row again for numberL > 1
            Console.WriteLine(firstValue);
            //second row part 1
            Console.Write(secondValue);

            if (firstValue + secondValue - 128 <= 26)
            {
                sum = (char)(firstValue + secondValue - 64);
            }
            else
            {
                sum = (char)(firstValue + secondValue - 90);
            }
            //second row part 2
            Console.WriteLine(sum);

            firstValue = secondValue;
            secondValue = sum;

            //calc and print third row +
            for (int i = 2; i < numberL; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if ((firstValue + secondValue - 128) <= 26)
                    {
                        sum = (char)(firstValue + secondValue - 64);
                    }
                    else
                    {
                        sum = (char)(firstValue + secondValue - 90);
                    }

                    //just like factorial
                    firstValue = secondValue;
                    secondValue = sum;

                    if (j == 0)
                    {
                        Console.Write(sum + new string(' ', i - 1));
                    }
                    else
                    {
                        Console.WriteLine(sum);
                    }
                }
            }
        }
        else //first row only if numberL = 1;
        {
            Console.WriteLine(firstValue);
        }
    }
}