namespace BGCoder.com
{
    using System;
    using System.Linq;

    class BinaryDigitsTask
    {
        static void Main(string[] args)
        {
            char digitB = char.Parse(Console.ReadLine());
            int inputLinesCount = int.Parse(Console.ReadLine());

            int[] resultsArray = new int[inputLinesCount];
            int count = 0;

            for (int i = 0; i < inputLinesCount; i++)
            {
                long input = long.Parse(Console.ReadLine());

                string binaryString = Convert.ToString(input, 2);

                for (int j = 0; j < binaryString.Length; j++)
                {
                    if (binaryString[j] == digitB)
                    {
                        count++;
                    }
                }

                resultsArray[i] = count;
                count = 0;
            }

            Console.Write(string.Join("\n", resultsArray));
        }
    }
}