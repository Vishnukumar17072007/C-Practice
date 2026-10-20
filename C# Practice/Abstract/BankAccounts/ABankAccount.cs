using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.BankAccounts
{
    abstract class ABankAccount
    {
        protected double Balance;

        public void CheckBalance()
        {
            Console.WriteLine("BANK BALANCE = " + Balance + "rs");
        }

        public void Deposit(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("Deposited amount = " + amount);
        }

        public abstract void Withdraw(int amount);
    }
}
