/*
 * 3. Write a method that from a given array of students finds all students whose 
 *    first name is before its last name alphabetically. Use LINQ query operators.
 * 4. Write a LINQ query that finds the first name and last name of all students 
 *    with age between 18 and 24.
 * 5. Using the extension methods OrderBy() and ThenBy() with lambda expressions 
 *    sort the students by first name and last name in descending order. 
 *    Rewrite the same with LINQ.
 */

namespace FirstLastCompareToNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class QueriesAndExpressions
    {
        static void Main()
        {
            var students = new[] { new {firstName = "Doroty", secondName = "May", Age = 18}, 
                                   new {firstName = "Doroty", secondName = "Cartahena", Age = 18}, 
                                   new {firstName = "Johnny", secondName = "Bravo", Age = 33 }};

            //3.
            var compareStudentNames =
                from student in students
                where student.firstName.CompareTo(student.secondName) < 0
                select student;

            Console.WriteLine("" + '┌' + new string('─', 35) + " Task 3 " + new string('─', 35) + '┐');
            foreach (var item in compareStudentNames)
                Console.WriteLine("  {0} {1}", item.firstName, item.secondName);

            //4.
            var compareStudentsAges =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            Console.WriteLine("\n" + '┌' + new string('─', 35) + " Task 4 " + new string('─', 35) + '┐');
            foreach (var item in compareStudentsAges)
                Console.WriteLine("  {0} {1}", item.firstName, item.secondName);

            //5.
            var lambdaExpr = 
                    students.OrderByDescending(student => student.firstName)
                            .ThenByDescending(student => student.secondName);

            Console.WriteLine("\n" + '┌' + new string('─', 32) + " Task 5 lambda" + new string('─', 32) + '┐');
            foreach ( var item in lambdaExpr)
                Console.WriteLine("  {0} {1}", item.firstName, item.secondName);

            //5.b
            var linqQuery =
                from student in students
                orderby student.firstName descending, student.secondName descending
                select student;

            Console.WriteLine();
            foreach ( var item in linqQuery)
                Console.WriteLine("  {0} {1}", item.firstName, item.secondName);
        }
    }
}