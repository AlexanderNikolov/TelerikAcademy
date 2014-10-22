using System;
using System.Linq;

interface IDepositable<T>
{
    T DepositMoney(decimal money);
}