/* 1. Define a class that holds information about a mobile phone device: model, 
 *    manufacturer, price, owner, battery characteristics (model, hours idle and 
 *    hours talk) and display characteristics (size and number of colors). 
 *    Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 * 2. Define several constructors for the defined classes that take different sets of 
 *    arguments (the full information for the class or part of it). Assume that model 
 *    and manufacturer are mandatory (the others are optional). All unknown data fill with null.
 * 5. Use properties to encapsulate the data fields inside the GSM, Battery and 
 *    Display classes. Ensure all fields hold correct data at any given time. 
 */

using System;
using System.Collections.Generic;

namespace MobileDeviceClasses
{
    public class GSM
    {
        //top brands (update here!)
        public enum Brands
        {
            Apple,
            Blackberry,
            HTC,
            Huawai,
            Lenovo,
            LG,
            Nokia,
            Motorola,
            Samsung,
            Sony
        }

        //class fields
        private string model;
        private decimal? price;
        private string owner;
        private Display display;
        private Battery battery;

        //6. Add a static field and a property  IPhone4S in the GSM class to hold the information 
        //   about iPhone 4S
        private static readonly GSM iPhone4S = new GSM("iPhone4S", Brands.Apple);
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        #region Properties
        public Brands Brand { get; set; }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid price!");
                this.price = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        #endregion

        //instance of class Display
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        //instance of class Battery
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        //9. Add a property CallHistory in the GSM class to hold a list of the performed calls. 
        public Call CallHistory
        {
            get;
            set;
        }


        //class constructor
        public GSM(string model, Brands manufacturer, decimal? price = null,
                string owner = null, Display display = null, Battery battery = null)
        {
            this.Model = model;
            this.Price = price;
            this.Brand = manufacturer;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
            this.CallHistory = new Call(DateTime.Now, "", TimeSpan.Zero); //<-
        }


        //4. Add a method in the GSM class for displaying all information about it. 
        //   Try to override ToString().
        public override string ToString()
        {
            return string.Format(
                "  Brand:  {0}\n  model:  {1}\n  price:  {2:C2}\n  owner:  {3}\n  display {4}\n  battery {5}\n",
                this.Brand, this.model, this.price, this.owner, this.display, this.battery);
        }

        //methods section
        public void Info()
        {
            Console.WriteLine("" + '┌' + new string('─', 36) + " Info " + new string('─', 36) + '┐');
            Console.WriteLine(this.ToString());
            Console.WriteLine("" + '└' + new string('─', 78) + '┘');
        }
    }
}
