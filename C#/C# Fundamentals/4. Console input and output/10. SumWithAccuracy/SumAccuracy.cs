namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// Write a program to calculate the sum (with accuracy of 0.001): 
    /// 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...";
    /// </summary>
    class SumAccuracy
    {
        static void Main()
        {
            double sumSequence = 1d;
            double minorFractions = 1d;

            for (double counter = 2; minorFractions > 0.001; counter++)
            {
                minorFractions = 1 / counter;

                if (counter % 2 == 0)
                {
                    sumSequence += minorFractions;
                }
                else
                {
                    sumSequence -= minorFractions;
                }
            }

            Console.WriteLine("Sum of sequence (with 0.001 accuracy) is: {0:F3}", sumSequence);
        }
    }
}