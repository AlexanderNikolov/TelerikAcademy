namespace BankAccounts
{
    using System;

    public class Person : Customer
    {
        private string egn;

        public Person(string name, string address, string egnNumber)
            : base(name, address)
        {
            this.EGN = egnNumber;
        }

        public string EGN
        {
            get { return this.egn; }
            set
            {
                if (value.Length != 8)
                    throw new ArgumentException("Invalid EGN");
                this.egn = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Name, this.Address);
        }
    }
}
