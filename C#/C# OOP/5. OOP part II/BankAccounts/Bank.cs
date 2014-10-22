namespace BankAccounts
{
    using System;
    using System.Collections.Generic;

    public class Bank
    {
        private string name;
        private readonly List<Account> accounts = new List<Account>();

        //.tor
        public Bank(string name)
        {
            this.Name = name;
        }

        //prop
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("This field can\'t be null or empty!");
                this.name = value;
            }
        }

        //метод за добавяне на нов запис към листа със сметки
        public Bank AddAccount(params Account[] accounts)
        {
            foreach (var item in accounts)
                this.accounts.Add(item);

            return this;
        }

        public Bank RemoveAccount(Account account)
        {
            this.accounts.Remove(account);

            return this;
        }
    }
}
