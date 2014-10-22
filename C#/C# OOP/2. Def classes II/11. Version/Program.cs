/*
 * 11. Create a [Version] attribute that can be applied to structures, classes, 
 *    interfaces, enumerations and methods and holds a version in the format 
 *    major.minor (e.g. 2.11). Apply the version attribute to a sample class 
 *    and display its version at runtime.
 */
using System;
using CustomAttributes;

[Version("1.01")]
class ProgramUI
{
    static void Main()
    {
        object[] obj = typeof(ProgramUI).GetCustomAttributes(false);

        Console.WriteLine("class ProgramUI ver {0}", obj[0]);
    }
}
