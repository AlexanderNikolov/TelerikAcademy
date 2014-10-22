/*
 * 1. We are given a school. In the school there are classes of students.
 * Each class has a set of teachers. Each teacher teaches a set of disciplines.
 * Students have name and unique class number. Classes have unique text
 * identifier. Teachers have name. Disciplines have name, number of lectures
 * and number of exercises. Both teachers and students are people. Students,
 * classes, teachers and disciplines could have optional comments (free text block).
 *
 * Your task is to identify the classes (in terms of  OOP) and their attributes
 * and operations, encapsulate their fields, define the class hierarchy and
 * create a class diagram with Visual Studio.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using SchoolSpace;

class Program
{
    static void Main()
    {
        //test - new instances
        School testSchool = new School("Telerik Academy");
        Class testClass = new Class("Online flow 2013");
        Teacher testTeacher = new Teacher("Ivailo", "numeroUno", "Kenov");
        Student testStudent = new Student("Winnie", "The", "Pooh", "2263589");

        //output
        Console.WriteLine(testSchool);
        Console.WriteLine(testClass);
        Console.WriteLine(testTeacher);
        Console.WriteLine(testStudent);
        Console.WriteLine();

        //test iteration
        var classes = new List<School> { new Class("Autumn 2013"), new Class("Spring 2013") };
        classes.Add(testClass);
        foreach (var item in classes)
        {
            Console.WriteLine(item);
        }
    }
}
