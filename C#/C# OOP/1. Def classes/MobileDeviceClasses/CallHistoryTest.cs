/* 12. Write a class GSMCallHistoryTest to test the call history 
 *     functionality of the GSM class. 
 */

using System;
using System.Linq;

using MobileDeviceClasses;

class CallHistoryTest
{
    public static void TestMethod()
    {
        //- Create an instance of the GSM class;
        GSM note2 = new GSM("Galaxy Note 3",
                                    GSM.Brands.Samsung,
                                    null,
                                    null,
                                    new Display(5.7, 256000000),
                                    new Battery(Battery.BatteryType.Nikopol9V));

        //- add few calls
        note2.CallHistory.Add(new Call(DateTime.Now.AddMinutes(5263), "0112 654 321", new TimeSpan(0, 15, 30)));
        note2.CallHistory.Add(new Call(DateTime.Now.AddMinutes(14123), "0112 654 321", new TimeSpan(0, 28, 15)));
        note2.CallHistory.Add(new Call(DateTime.Now.AddMinutes(-8564), "0112 654 321", new TimeSpan(0, 05, 12)));
        note2.CallHistory.Add(new Call(DateTime.Now.AddMinutes(19191), "0112 654 321", new TimeSpan(0, 43, 06)));
        note2.CallHistory.Add(new Call(DateTime.Now.AddMinutes(5347), "0112 654 321", new TimeSpan(0, 6, 49)));

        //- Display the information about the calls;
        note2.CallHistory.CallInfo();

        //- assuming that the price per minute is 0.37 calculate and print the total 
        //  price of the calls in the history;
        decimal callPrice = 0.37m; // price per minute

        Console.WriteLine("\n  Total: {0:F2}лв.", note2.CallHistory.PriceCalc(callPrice));

        // - Remove the longest call from the history and calculate the total price again;
        note2.CallHistory.RemoveLongestCall();
        Console.WriteLine("\n  Delete longest call");
        Console.WriteLine("\n  New total: {0:C2}\n", note2.CallHistory.PriceCalc(callPrice));

        //- Finally clear the call history and print it;
    }
}
