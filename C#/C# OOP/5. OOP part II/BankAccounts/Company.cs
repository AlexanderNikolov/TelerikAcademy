namespace BankAccounts
{
    using System;

    public class Company : Customer
    {
        private string eIK;

        public Company(string name, string address, string eik)
            : base(name, address)
        {
            this.eIK = eik;
        }

        public string EIK
        {
            get { return this.eIK; }
            set
            {
                if (!this.eIK.StartsWith("BG"))
                    throw new ArgumentException("Invalid EIK");
                this.eIK = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Name, this.Address);
        }
    }
}
