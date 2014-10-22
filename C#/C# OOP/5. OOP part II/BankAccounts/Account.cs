namespace BankAccounts
{
    using System;
    using System.Linq;

    public abstract class Account
    {
        protected decimal balance = 0;
        protected decimal rateOfInterest = 0;
        protected Customer customer;

        public Account(Customer customer, decimal balance, decimal rate)
        {
            this.Balance = balance;
            this.Rate = rate;
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                    throw new Exception("This balance is hot!");
                this.balance = value;
            }
        }

        public decimal Rate
        {
            get { return this.rateOfInterest; }
            set
            {
                if (value < 0)
                    throw new Exception("Error in rate!");
                this.rateOfInterest = value;
            }
        }

        //methods
        public virtual decimal CalcRate(decimal months)
        {
            if (months <= 0)
                return 0;

            return this.Balance * (this.Rate / 100) * months;
        }
    }
}
