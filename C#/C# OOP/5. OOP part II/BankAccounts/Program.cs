/*
 * A bank holds different types of accounts for its customers: 
 *  deposit accounts, loan accounts and mortgage accounts. 
 *  Customers could be individuals or companies.
 * All accounts have customer, balance and interest rate (monthly based). 
 * Deposit accounts are allowed to deposit and with draw money. 
 * Loan and mortgage accounts can only deposit money. 
 * All accounts can calculate their interest amount for a given period (in months). 
 * In the common case its is calculated as follows: number_of_months * interest_rate.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using BankAccounts;

class Program
{
    static void Main()
    {
        Bank bank = new Bank("BloodyMoney");
        Person me = new Person ( "name", "address", "01234567" );
        Company myCompany = new Company("companyName", "companyAddress", "BG123456");
        Account myAccount = new Deposit(me , 100m, 0.25m); //instance of class Person using here
        Account companyAccount = new Loan(myCompany, 1000000m, 10m);

        //List of accounts, Add/Remove account
        List<Account> accounts = new List<Account>();
        accounts.Add(companyAccount);
        accounts.Add(myAccount);

        //rates, individual or companies
        var months = 12m;
        var iRate = myAccount.CalcRate(months);


        //output
        Console.WriteLine("new bank: {0, 16}", bank.Name);
        Console.WriteLine("customer type: {0} {1} {2}", me.Name, me.Address, me.EGN);
        Console.WriteLine("customer type: {0} {1} {2}", myCompany.Name, myCompany.Address, myCompany.EIK);
        Console.WriteLine();
        Console.WriteLine("rate/individual accounts: {0:C2} for period of: {1} months", iRate, months);
    }
}
