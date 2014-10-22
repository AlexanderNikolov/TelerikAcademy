namespace BankAccounts
{
    using System;

    public class Loan : Account, IDepositable<Loan>
    {
        public Loan(Customer customer, decimal balance, decimal rate)
            : base(customer, balance, rate)
        {
        }

        //.face implem
        public Loan DepositMoney(decimal money)
        {
            this.Balance += money;

            return this;
        }

        //methods
        public override decimal CalcRate(decimal months)
        {
            if (this.customer is Company)                   
                return base.CalcRate(months - 2);

            if (this.customer is Person)
                return base.CalcRate(months - 3);

            return base.CalcRate(months);
        }
    }
}
