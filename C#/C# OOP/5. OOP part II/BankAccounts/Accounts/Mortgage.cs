namespace BankAccounts
{
    using System;

    public class Mortgage : Account, IDepositable<Mortgage>
    {
        public Mortgage(Customer customer, decimal balance, decimal rate)
            : base(customer, balance, rate)
        {
            this.customer = customer;
        }

        //.fce implem
        public Mortgage DepositMoney(decimal money)
        {
            this.Balance += money;

            return this;
        }

        public override decimal CalcRate(decimal months)
        {
            if (this.customer is Company)
                return base.CalcRate(Math.Min(months, 12) / 2 + Math.Max(months - 12, 0));

            if (this.customer is Person)
                return base.CalcRate(months - 6);

            return base.CalcRate(months);
        }
    }
}
