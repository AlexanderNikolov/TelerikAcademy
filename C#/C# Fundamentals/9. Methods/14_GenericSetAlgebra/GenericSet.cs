using System;
using System.Linq;

class GenericSetAlgebra <T, T1, T2, T3>
{
    public GenericSetAlgebra ()
    {
    }
    static void Main()
    {
        //Write methods to calculate minimum, maximum, average, sum and product
        //of given set of integer numbers. Use variable number of arguments.

        T[] mix = new T[] { 1, 222, 5, 1337, -14, -136, 159, 69, 0 };
        int[] result = new int[5];

        GetSet(mix, 0, mix.Length - 1);

        foreach (int item in mix)
        {
            result[3] += item;
            result[4] *= item;
        }
        
        result[0] = mix[0];
        result[1] = mix[mix.Length - 1];
        result[2] = result[4] / mix.Length;

        //test
        Console.WriteLine("mininum {0} ", result[0]);
        Console.WriteLine("maximum {0} ", result[1]);
        Console.WriteLine("average {0} ", result[2]);
        Console.WriteLine("sum {0} ", result[3]);
        Console.WriteLine("product {0} ", result[4]);

        //Console.WriteLine(string.Join(", ", mix));
    }
    //quicksort
    public static void T GetSet(T[] array, T left, T right)
    {
        int i = left;
        int j = right;
        int marker = array[left + (right - left >> 1)];

        while (i <= j)
        {
            while (array[i].CompareTo(marker) < 0)
                i++;

            while (array[j].CompareTo(marker) > 0)
                j--;

            if (i <= j)
            {
                int tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;

                i++;
                j--;
            }
        }
        // Recursive calls
        if (left < j)
            GetSet(array, left, j);
        if (i < right)
            GetSet(array, i, right);
    }
}

