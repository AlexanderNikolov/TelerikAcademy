/*
 * Write a program that enters file name along with its full file path
 * (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
 * Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch
 * all possible exceptions and print user-friendly error messages
 */

namespace TAonlineHomework7exceptions
{
    using System;
    using System.IO;

    class FileReadAllTextProgram
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write(@"Enter full path to file and file name (e.g. C:\WINDOWS\win.ini) ");
                string path = Console.ReadLine();
                string allText = File.ReadAllText(path);
                Console.WriteLine(allText);
            }
            catch (FileNotFoundException)
            {
                throw new ArgumentException("\tFile not found!\n");
            }
            catch (FieldAccessException)
            {
                throw new ArgumentException("\tFile is read-only or you does not have the required permission\n");
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentException("\tPath is null\n");
            }
        }
    }
}
