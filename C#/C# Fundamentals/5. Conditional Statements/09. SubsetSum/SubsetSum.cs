namespace TAonline.CSharp.ConditionalStatements.Homework5
{
    using System;

    /// <summary>
    /// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
    /// Example: 3, -2, 1, 1, 8   1+1-2 = 0.
    /// </summary>
    class SubsetSum
    {
        static void Main()
        {
            int arrLenght = 5;
            int[] numbers = new int[arrLenght];
            int subsetSum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter real number ({0} from 5) ", i + 1); 
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < arrLenght; ++j)
                {
                    subsetSum = numbers[i] + numbers[j]; //first subset and check
                    if (subsetSum == 0)
                    {
                        Console.WriteLine("{0} + {1} = {2}", 
                            numbers[i], numbers[j], subsetSum);
                    }

                    for (int k = j + 1; k < arrLenght; ++k)
                    {
                        subsetSum += numbers[k];
                        if (subsetSum == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}", 
                                numbers[i], numbers[j], numbers[k], subsetSum);
                        }

                        for (int n = k + 1; n < arrLenght; ++n)
                        {
                            subsetSum = subsetSum + numbers[n];
                            if (subsetSum == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = {4}",
                                    numbers[i], numbers[j], numbers[k], numbers[n], subsetSum);
                            }

                            for (int m = n + 1; m < arrLenght; m++)
                            {
                                subsetSum += numbers[m];
                                if (subsetSum == 0)
                                {
                                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}",
                                        numbers[i], numbers[j], numbers[k], numbers[n], numbers[m], subsetSum);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}