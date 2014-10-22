using System;
using System.Collections.Generic;
using System.Linq;
using HumanSpace;

class Program
{
    static void Main()
    {
        //a test
        List<Student> students = new List<Student> { new Student("Winnie", "Pooh", "6"),
                                                     new Student("Elefant", "Lumpi", "5"),
                                                     new Student("Kenga", "Roo", "4"), 
                                                     new Student("Tiger", "Tiger", "3")};

        var collection =
            from student in students
            orderby student.Grade ascending
            select student;

        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //b test
        List<Worker> workers = new List<Worker> { new Worker("John", "Doe", 150, 8), 
                                                  new Worker("Max", "Pate", 200, 9), 
                                                  new Worker("Sam", "Tily", 180, 8), 
                                                  new Worker("Kris", "Fairy", 160, 8) };

        var collection2 =
            from worker in workers
            orderby worker.MoneyPerHour() descending
            select worker;

        foreach (var item in collection2)
        {
            Console.Write(item + " ");
            Console.WriteLine(item.MoneyPerHour());
        }
    }
}
