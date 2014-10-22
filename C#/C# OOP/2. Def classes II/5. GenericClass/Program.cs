/*
 * 5. Write a generic class GenericList<T> that keeps a list of elements
 *    of some parametric type T. Keep the elements of the list in an array
 *    with fixed capacity which is given as parameter in the class constructor.
 *    Implement methods for adding element, accessing element by index, removing
 *    element by index, inserting element at given position, clearing the list,
 *    finding element by its value and ToString(). Check all input parameters to
 *    avoid accessing elements at invalid positions.
 *
 * 6. Implement auto-grow functionality: when the internal array is full,
 *    create a new array of double size and move all elements to it.
 *
 * 7. Create generic methods Min<T>() and Max<T>() for finding the minimal
 *    and maximal element in the  GenericList<T>. You may need to add a generic
 *    constraints for the type T.
 */

namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ProgramUI
    {
        static void Main()
        {
            GenericList<int> numbers = new GenericList<int>();

            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(6);
            numbers.Add(10);
            numbers.Add(8);

            Console.WriteLine(numbers.ToString());
            Console.WriteLine("\nnumber of elements in list: {0}", numbers.Count);
            Console.WriteLine("\nelement at index [0]: {0}", numbers[0]);

            numbers.Clear();
            Console.WriteLine("\ntest list.Clear()", numbers.ToString());
        }
    }
}
