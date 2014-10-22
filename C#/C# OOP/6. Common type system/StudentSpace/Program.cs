/*
 * 1. Define a class Student, which contains data about a student – first, middle and last name, 
 *    SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
 *    Use an enumeration for the specialties, universities and faculties. 
 *    Override the standard methods, inherited by  System.Object: 
 *    Equals(), ToString(), GetHashCode() and operators == and !=.
 * 2. Add implementations of the ICloneable interface. The Clone() method should deeply copy 
 *    all object's fields into a new object of type Student.
 * 3. Implement the  IComparable<Student> interface to compare students by names 
 *    (as first criteria, in lexicographic order) and by social security number 
 *    (as second criteria, in increasing order).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using StudentSpace;

class Program
{
    static void Main()
    {
        Student student1 = new Student("Gosho", 12345678);
        Student student2 = new Student("Pesho", 56789123);
        Student student3 = new Student("Anto", 45678912);
        Student student4 = new Student("Georgi", 34567956);

        var collection = new List<Student>() { };
        collection.Add(student1);
        collection.Add(student2);
        collection.Add(student3);
        collection.Add(student4);

        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }

        //test properties
        student1.Email = "mail@microsoft.com";
        Console.WriteLine("\nStudent1 e-mail: {0}", student1.Email);

        //test deep copy
        Student student5 = (Student)student1.Clone();
        Console.WriteLine("\n{0} {1}", student1, student5);
        student5.FirstName = "Kratuncho"; //change prop to test deep or shallow copy we have
        Console.WriteLine("{0} {1}", student1, student5);

        //test equality
        Console.WriteLine("\nStudent1.Equals(Student2): {0}", student1.Equals(student2));
        Console.WriteLine("Student1 == Student2: {0}", student1 == student2);
        Console.WriteLine("Student1 != Student2: {0}\n", student1 != student2);

    }
}