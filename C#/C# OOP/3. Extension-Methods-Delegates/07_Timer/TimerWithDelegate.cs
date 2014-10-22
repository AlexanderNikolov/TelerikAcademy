/*
 * 7. Using delegates write a class Timer that has can execute certain method 
 *    at each t seconds.
 */

namespace TimerSpace
{
    using System;
    using System.Threading;

    public delegate void RunThicking();

    public static class Timer
    {
        public static readonly Action Run = 
            new Action(() => Console.WriteLine(DateTime.Now.ToString("T")));
    }

    public class Program
    {
        static void Main()
        {
            const int Interval = 2000; //2 seconds

            RunThicking tickTack = new RunThicking(Timer.Run);

            //output
            int count = 20;
            while (count > 0)
            {
                tickTack();
                Thread.Sleep(Interval); //console delay
                Console.Clear();
                count--;
            }
            
        }
    }
}
