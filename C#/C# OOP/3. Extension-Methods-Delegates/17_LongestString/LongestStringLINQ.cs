using System;
using System.Collections.Generic;
using System.Linq;

class LongestStringLINQ
{
    static void Main()
    {
        List<string> testList = new List<string> {"abracadabra", 
                                                  "globeltrotters", 
                                                  "tarambukijuki", 
                                                  "Kill \'m all and lets God sort \'m out", 
                                                  "Lorem ipsum dolor sit amet" };

        // 1. solution with LINQ
        var collection =
                         from str in testList
                         orderby str.Length descending
                         select str;

        bool doOnce = true;
        foreach (var item in collection)
        {
            while (doOnce)
            {
                Console.WriteLine(item);
                doOnce = false;
            }
        }

        // 2. fastest one. More for Aggregate method http://msdn.microsoft.com/en-us/library/bb548651(v=vs.110).aspx
        var longest = testList.Aggregate("", (max, current) => max.Length > current.Length ? max : current);

        Console.WriteLine(longest);
    }
}
