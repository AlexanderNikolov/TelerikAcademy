/* 8. Create a class Call to hold a call performed through a GSM. It should contain 
 *    date, time, dialed phone number and duration (in seconds).
 *10. Add methods in the GSM class for adding and deleting calls from the calls history. 
 *    Add a method to clear the call history.
 *11. Add a method that calculates the total price of the calls in the call history. 
 *    Assume the price per minute is fixed and is provided as a parameter.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileDeviceClasses
{
    public class Call : IComparable <Call> //make this class collection
    {
        private DateTime date;
        private string dialedNumber;
        private TimeSpan duration = TimeSpan.Zero;

        private readonly List<Call> calls = new List<Call>();

        #region constructors
        /// <summary>
        /// default parameterless constructor (just for training :))
        /// </summary>
        public Call() { 
        }
        
        /// <summary>
        /// constructor w parameters and re-use
        /// </summary>
        public Call(DateTime date, string dialedNumber, TimeSpan duration) 
            : this()
        {
            this.Date = date;
            this.Time = time;
            this.Dialed = dialedNumber;
            this.CallTime = duration;
        }
        #endregion

        #region class properties
        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Date cannot be null!");
                this.date = value;
            }
        }

        public string Dialed
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }

        public TimeSpan CallTime
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        #endregion

        /// <summary>
        /// mandatory method for every IComparable class
        /// </summary>
        public int CompareTo(Call other) { 
            
            return (int)(this.CallTime - other.CallTime).TotalSeconds;
        }

        #region override methods
        public override string ToString() {
            StringBuilder callInfo = new StringBuilder();

            callInfo.Append(string.Format("  {0, -26} -- {1} -- Duration: {2}",
                this.Date, this.Dialed, this.CallTime));

            return callInfo.ToString();
        }
        #endregion 

        #region custom methods
        public void CallInfo()
        {
            StringBuilder call = new StringBuilder();
            foreach (var item in calls)
            {
                call.AppendLine(item.ToString());
            }

            Console.WriteLine( call.ToString());
        }
        
        public void Add(Call call)
        {
            calls.Add(call);
        }

        public void RemoveLongestCall()
        {
            var longest = calls.Max();

            calls.Remove(longest);
        }

        public void Clear()
        {
            calls.Clear();
        }

        public decimal PriceCalc(decimal pricePerMinute)
        {
            return (decimal)calls.Sum(x => x.CallTime.TotalMinutes) * pricePerMinute;
        }
        #endregion
    }
}
