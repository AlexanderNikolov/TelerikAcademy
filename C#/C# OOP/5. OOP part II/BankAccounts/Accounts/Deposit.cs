namespace BankAccounts
{
    using System;

    public class Deposit : Account, IDepositable<Deposit>, IDrawable<Deposit>
    {
        public Deposit(Customer customer, decimal balance, decimal rate)
            : base(customer, balance, rate)
        {
        }

        //.face implementation
        public Deposit DepositMoney(decimal money)
        {
            this.Balance += money;

            return this;
        }

        public Deposit WithDraw(decimal money)
        {
            this.Balance -= money;

            return this;
        }

        //methods
        public override decimal CalcRate(decimal months)
        {
            if (this.Balance <= 0)
                return 0;

            return base.CalcRate(months);
        }
    }
}
