namespace TAonline.CSharp.PrimitiveTypesAndVariables.Homework2
{
    using System;

    class Tasks
    {
        static void Main()
        {
            Console.Title = "C# Fundamentals I (2013). Homework 2";

            //Task1. Declare 5 vars using for each of them most appropriate of the type            
            sbyte var1 = -115;
            Console.WriteLine("Example for sbyte type  {0}", var1);

            ushort var2 = 52130;
            Console.WriteLine("Example for ushort type  {0}", var2);
            
            uint var3 = 4825932u;
            Console.WriteLine("Example for uint type  {0}", var3);
            
            byte var4 = 97;
            Console.WriteLine("Example for byte type  {0}", var4);
            
            int var5 = -10000;
            Console.WriteLine("Example for int type  {0}", var5);

            //Task2. Which of the following values..
            Console.WriteLine();
            Console.WriteLine("This is float {0}", 34.567839023f);
            Console.WriteLine("This is float {0}", 8923.1234857f);
            Console.WriteLine("This is float {0}", 3456.091f);
            Console.WriteLine("This is double {0}", 12.345d);
            Console.WriteLine();

            //Task3. Write a program for safety compaire float point numbers..
            float var6M = 5.3f;
            float var7M = 6.01f;
            float var9M = 5.0000001f;
            float var10M = 5.0000003f;
            if (Math.Abs(var7M - var6M) != 0.000001)
            {
                Console.WriteLine("{0} not equal to {1} in precision 0.000001", var6M, var7M);
            }
            if (Math.Abs(var10M - var9M) < 0.000001)
            {
                Console.WriteLine("{0} equal to {1} in precision 0.000001", var9M, var10M);
            }

            //Task5. Declare a character variable and assign with a simbol with Unicode of 72
            char varCh = '\u0048';
            Console.WriteLine();
            Console.WriteLine(varCh);

            //Task6. Declare boolean var isFemale ..
            bool isFemale = false;
            Console.WriteLine();
            Console.WriteLine("isFemale = {0}", isFemale);
            Console.WriteLine();

            //Task7. 2 string vars ..
            string varHello = "Hello";
            string varWorld = "World";
            object varString = varHello + " " + varWorld;
            Console.WriteLine(varString);
            string varStr = varString.ToString(); //cast method - object to string
            Console.WriteLine();

            //Task8. Avoid quotation difficulties ..
            string varStr2 = "The \"use\" of quotation causes difficulties";
            string varStr3 = @"The 'use' of quotation causes difficulties";
            Console.WriteLine(varStr2);
            Console.WriteLine(varStr3);
            Console.WriteLine();

            //Task10. Declare variables
            string firstName;
            string familyName;
            byte age;
            char gender;
            uint numberID;
            Console.WriteLine();

            //Task13. null
            int? myVar13 = null;
            double? myVar14 = null;
            Console.WriteLine();
            Console.WriteLine("Sorry, result of next operations is NULL (not visible)!");
            Console.Write((object)myVar13); Console.Write(" "); Console.WriteLine((object)myVar14);
            Console.WriteLine(myVar13 + 1);
            Console.WriteLine(myVar14 + null);

            //Task14. Declare variable
            string productName;
            int balance;
            string bankName, bankIBAN, bankBIC, cardID, card2, card3;
        }
    }
}