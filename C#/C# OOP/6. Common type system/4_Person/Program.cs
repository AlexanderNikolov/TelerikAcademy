/*
 * 4. Create a class Person with two fields – name and age. Age can be left 
 *    unspecified (may contain null value. Override ToString() to display 
 *    the information of a person and if age is not specified – to say so. 
 *    Write a program to test this functionality.
 */

using System;
using System.Collections.Generic;
using Persons;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John", "25");
        Person person2 = new Person("Paul", "18");

        Console.WriteLine(person);
        Console.WriteLine();
        Console.WriteLine(person2);

    }
}