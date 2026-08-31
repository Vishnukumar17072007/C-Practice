using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.Bank_Account
{
    abstract class BankAccount
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

    class SavingAccount : BankAccount
    {
        public override void Withdraw(int amount)
        {
            if(Balance - amount <= 500)
            {
                Console.WriteLine("Saving accounts must have minimum balance of 500. Cannot withdraw amount.");
            }
            else
            {
                Balance = Balance - amount;
                Console.WriteLine("Withdrawal amount = " + amount);
            }
        }
    }

    class CurrentAccount : BankAccount
    {
        public override void Withdraw(int amount)
        {
            if( amount > Balance + 1000) //here 1000 represents overdraft amount which is setted by banks that user can borrow money from the bank upto a limit. The balance goes to negative
            {
                Console.WriteLine("Amount exceeds the overdraft amount try lesser amount!.");
            }
            else
            {
                Balance = Balance - amount;
            }
        }
    }

}
