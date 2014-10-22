/*
 * 2. Implement a set of extension methods for IEnumerable<T> that implement 
 *    the following group functions: sum, product, min, max, average.
 */

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        //Etalon extension
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }

        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic result = default(T);
            foreach (T item in collection)
            {
                result += item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic result = 1;
            foreach (T item in collection)
            {
                result *= item;
            }

            return result;
        }
        
        public static T Average<T>(this IEnumerable<T> collection)
        {
            dynamic result = 1;
            foreach (T item in collection)
            {
                result += item;
            }

            return result/(dynamic)collection.Count();
        }

        public static T Min<T>(this IEnumerable<T> elements)
        {
            dynamic min = long.MaxValue;

            foreach (T item in elements)
                if (item < min)
                    min = item;

            return min;
        }

        public static T Max<T>(this IEnumerable<T> elements)
        {
            dynamic max = long.MinValue;

            foreach (T item in elements)
                if (item > max)
                    max = item;

            return max;
        }
        
    }

    class Program
    {
        static void Main()
        {
            List<double> test = new List<double>() { 5.25 , 25.0, 50 };

            //test here
            Console.WriteLine( "Sum = {0}", test.Sum() );
            Console.WriteLine( "Product = {0}", test.Product() );
            Console.WriteLine( "Max = {0}", test.Max() );
            Console.WriteLine( "Min = {0}", test.Min() );
            Console.WriteLine( "Average = {0}", test.Average() );

        }
    }
}
