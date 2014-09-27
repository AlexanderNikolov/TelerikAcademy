using System;
using System.Linq;

class BinaryDigits
{
    static void Main(string[] args)
    {
        char digitB = 
            char.Parse(Console.ReadLine());
        int inputLines = 
            int.Parse(Console.ReadLine());
        
        int[] resultsArray = 
            new int[inputLines];
        int count = 0;
        
        for (int ii = 0; ii < inputLines ; ii++)
        {
            long input = 
                long.Parse(Console.ReadLine());
            
            string binaryString = 
                Convert.ToString(input, 2);

            for (int jj = 0; jj < binaryString.Length; jj++)
            {
                if (binaryString[jj] == digitB)
                {
                    count++;    
                }
            }
            resultsArray[ii] = count;
            count = 0;
        }
        Console.Write(string.Join("\n", resultsArray));
    }
}

