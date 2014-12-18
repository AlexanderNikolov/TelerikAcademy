using System;
using System.Linq;

class FirstBiggerElementIndex
{
    static void Main()
    {
        //Write a method that returns the index of the first element in array 
        //that is bigger than its neighbors, or -1, if there’s no such element.

        int[] testArray = { 4, 1, 1, 3, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int result = FirstBiggerIndex(testArray);
        Console.WriteLine(result);

    }

    public static int FirstBiggerIndex(int[] array)
    {
        int result = 0;

        for (int position = 1; position < array.Length - 1; position++)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1] )
            {
                result = position;
                break;
            }
            else if (position == array.Length - 2)
            {
                result = - 1;
            }
        }
        
        return result;
    }
}

