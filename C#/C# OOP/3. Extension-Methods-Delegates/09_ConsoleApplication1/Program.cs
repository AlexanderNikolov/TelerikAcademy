using System;
using System.Collections.Generic;
using System.Linq;
using StudentSpace;

class Program
{
    static void Main()
    {
        /* Create a List<Student> with sample students. Select only the students 
         * that are from group number 2. Use LINQ query. Order the students by FirstName.
         */
        List<Student> students =
            new List<Student> { new Student("Josselin", "Beaumont", "1981", "2", "112-123456", "revenge@yahoo.com", 5, 4), 
                                new Student("John", "Rambo", "1982", "2", "911-123456", "fury@gmail.com", 4, 3), 
                                new Student("John", "Matrix", "1985", "2", "911-654321", "kill.m.all@gmail.com", 5, 2), 
                                new Student("Nikolai", "Rachenko", "1988", "2", "901-123456", "drink.and.shoot@mail.ru", 6, 3), 
                                new Student("James", "Bond", "007", "3", "112-654321", "license.to.kill@abv.bg", 4, 4) 
                              };
        var selection =
                       from student in students
                       where student.GroupNumber.Contains("2")
                       orderby student.FirstName
                       select student;

        PrintHeader("Task 9");
        foreach (var item in selection)
            Console.WriteLine(item);

        // 10. Implement the previous using the same query expressed with extension methods.
        List<Student> selection2 = students.GroupFilter(2);

        PrintHeader("Task 10");
        foreach (var item in selection2)
            Console.WriteLine(item);

        // 11. Extract all students that have email in abv.bg. Use string methods and LINQ.
        var selection3 =
                        from student in students
                        where student.EMail.Contains("@abv.bg")
                        select student;

        PrintHeader("Task 11");
        foreach (var item in selection3)
            Console.WriteLine(item);

        // 12. Extract all students with phones in Sofia. Use LINQ.
        var selection4 =
                        from student in students
                        where student.PhoneNumber.Contains("112")
                        select student;

        PrintHeader("Task 12");
        foreach (var item in selection4)
            Console.WriteLine(item);

        // 13. Select all students that have at least one mark Excellent (6) 
        //     into a new anonymous class that has properties – FullName and Marks. Use LINQ.
        var selection5 =
                        from student in students
                        where student.Marks.Contains(6)
                        select new
                        {
                            Student = string.Format("{0} {1}", student.FirstName, student.LastName),
                            Marks = string.Join(", ", student.Marks)
                        };

        PrintHeader("Task 13");
        foreach (var item in selection5)
            Console.WriteLine(item);

        //Console.WriteLine(typeof(string).Assembly.ImageRuntimeVersion);
    }

    static void PrintHeader(string task)
    {
        Console.WriteLine("\n" + '┌' + new string('─', 35) + " " + task + " " + new string('─', 34) + '┐' + "\n");
    }
}

/* 10. Implement the previous using the same query expressed with extension methods.
 */

public static class ExtensionMethods
{
    public static List<Student> GroupFilter(this List<Student> students, int groupNum)
    {
        IOrderedEnumerable<Student> custom =
                                             from student in students
                                             where student.GroupNumber == groupNum.ToString()
                                             orderby student.FirstName
                                             select student;

        return custom.ToList();
    }

    public static List<Student> MarksFilter(this List<Student> students, int mark, int number)
    {
        var custom2 =
                      from student in students
                      where student.Marks.Count(x => x == mark) == number
                      select student;

        return custom2.ToList();
    }
}
