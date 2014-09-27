namespace BGCoder.com
{
    using System;

    class Solver
    {
        static void Main(string[] args)
        {
            char firstValue =
                    char.Parse(Console.ReadLine());
            char secondValue =
                    char.Parse(Console.ReadLine());
            int numberL =
                    int.Parse(Console.ReadLine());

            if (numberL != 1)
            {
                char sum;

                Console.WriteLine(firstValue); //output first line
                Console.Write(secondValue); //output second line part 1

                if (firstValue + secondValue - 128 <= 26)
                {
                    sum = (char)(firstValue + secondValue - 64);
                }
                else
                {
                    sum = (char)(firstValue + secondValue - 90);
                }

                Console.WriteLine(sum); //output second line part 2

                firstValue = secondValue;
                secondValue = sum;

                //calc and output third line
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
            else //output first line only, if numberL = 1;
            {
                Console.WriteLine(firstValue);
            }
        }
    }
}