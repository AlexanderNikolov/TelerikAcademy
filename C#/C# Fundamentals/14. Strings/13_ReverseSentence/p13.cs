/*
 * Write a program that reverses the words in given sentence.
 * 	Example: 
 * 	"C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!"
 */
namespace _13_ReverseSentence
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            sentence = sentence.Trim('!');
            var words = sentence.Split(' ');
            Console.WriteLine(string.Join(" ", words.Reverse()) + "!");
        }
    }
}
