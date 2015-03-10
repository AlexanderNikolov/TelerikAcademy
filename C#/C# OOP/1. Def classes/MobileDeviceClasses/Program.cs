/* 
 *  7. Write a class GSMTest to test the GSM class:
 */

using System;
using System.Collections.Generic;
using MobileDeviceClasses;

class GSMTest_Program
{
    static void Main()
    {
        Console.BufferHeight = 100;

        List<GSM> modelArray = new List<GSM>(); 
        
        GSM Flex = new GSM("Flex", GSM.Brands.LG);
        GSM GalaxyNote2 = new GSM("Galaxy Note II", GSM.Brands.Samsung);
        GSM myPhone = new GSM("6250", GSM.Brands.Nokia, 700m, "me", new Display (3, 65000), new Battery(Battery.BatteryType.NiMH));

        //Create an array of few instances of the GSM class.
        modelArray.Add(Flex);
        modelArray.Add(GalaxyNote2);
        modelArray.Add(myPhone);

        //Display the information about the GSMs in the array.
        foreach (var item in modelArray)
            item.Info();

        //Display the information about the static property IPhone4S.
        Console.WriteLine("\n  Display the information about the static property IPhone4S\n");
        Console.WriteLine( GSM.IPhone4S );

        Console.WriteLine("" + '┌' + new string('─', 33) + " Calls Info " + new string('─', 33) + '┐');
        Console.WriteLine();
        CallHistoryTest.TestMethod();
    }
}

