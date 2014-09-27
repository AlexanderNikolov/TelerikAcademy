namespace BGCoder.com
{
    using System;

    class Solver
    {
        static void Main(string[] args)
        {
            string numberN = Console.ReadLine();

            int[] digits = new int[numberN.Length];

            while (true)
            {
                for (int i = 0; i < numberN.Length; i++)
                {
                    if (numberN[i] == '-' || numberN[i] == '.')
                    {
                        continue;
                    }
                    else
                    {
                        digits[i] = int.Parse(numberN[i].ToString());
                    }
                }

                int result = digits.Sum();
                if (result > 9)
                {
                    numberN = result.ToString();
                    digits = new int[numberN.Length];
                }
                else
                {
                    Console.WriteLine(result);
                    break;
                }
            }
        }
    }
}