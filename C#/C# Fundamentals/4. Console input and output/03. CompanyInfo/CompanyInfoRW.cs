namespace TAonline.CSharp.ConsoleInputOutput.Homework4
{
    using System;

    /// <summary>
    /// A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
    /// last name, age and a phone number. Write a program that reads the information about a company and its manager
    /// nand prints them on the console;
    /// </summary>
    class Task3
    {
        static void Main()
        {
            string name, address, website, firstName, lastName;
            int phone, fax, age, cellPhone;

            Console.Write("Enter company name: "); name = Console.ReadLine();
            Console.Write("Enter company adress: "); address = Console.ReadLine();
            Console.Write("Enter company phone: "); phone = int.Parse(Console.ReadLine());
            Console.Write("Enter company fax: "); fax = int.Parse(Console.ReadLine());
            Console.Write("Enter company website: "); website = Console.ReadLine();
            Console.Write("Enter company manager first name: "); firstName = Console.ReadLine();
            Console.Write("Enter company manager last name: "); lastName = Console.ReadLine();
            Console.Write("Enter company manager age: "); age = int.Parse(Console.ReadLine());
            Console.Write("Enter company manager cell phone: "); cellPhone = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("{0} \n{1} \n{2} \n{3} \n{4} \n{5} \n{6} \n{7} \n{8}", name, address, phone, fax, website, firstName, lastName, age, cellPhone);
        }
    }
}