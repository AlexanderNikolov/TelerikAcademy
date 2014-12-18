/*
 * * Write a program that reads a number N and generates and prints all 
 * the permutations of the numbers [1 … N]. 
 * Example:
 *  	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
 */

namespace TA2013_CSharp2_Arrays_homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int numberN = int.Parse(Console.ReadLine());
            string inputLine = "";

            for (int index = 1; index <= numberN; index++)
            {
                inputLine += "" + index.ToString();
            }

            Permutation pass = new Permutation();
            pass.InputSet = pass.MakeCharArray(inputLine);
            pass.PermutationCalc(0);

            Console.WriteLine("# of Permutations: {0}", pass.PermutationCount);
        }
    }

    class Permutation
    {
        private int elementLevel = -1;
        private int numberOfElements;
        private int[] permutationValue = new int[0];
        private char[] inputSet;
        private int permutationCount = 0;

        public char[] InputSet
        {
            get
            {
                return inputSet;
            }
            set
            {
                inputSet = value;
            }
        }

        public int PermutationCount
        {
            get
            {
                return permutationCount;
            }
            set
            {
                permutationCount = value;
            }
        }

        public char[] MakeCharArray(string InputString)
        {
            char[] charString = InputString.ToCharArray();
            Array.Resize(ref permutationValue, charString.Length);
            numberOfElements = charString.Length;

            return charString;
        }

        public void PermutationCalc(int k)
        {
            elementLevel++;
            permutationValue.SetValue(elementLevel, k);

            if (elementLevel == numberOfElements)
            {
                OutputPermutation(permutationValue);
            }
            else
            {
                for (int i = 0; i < numberOfElements; i++)
                {
                    if (permutationValue[i] == 0)
                        PermutationCalc(i);
                }
            }

            elementLevel--;
            permutationValue.SetValue(0, k);
        }

        private void OutputPermutation(int[] outputArray)
        {
            foreach (int i in outputArray)
            {
                Console.Write(inputSet.GetValue(i - 1));
            }

            Console.WriteLine();
            PermutationCount++;
        }
    }
}