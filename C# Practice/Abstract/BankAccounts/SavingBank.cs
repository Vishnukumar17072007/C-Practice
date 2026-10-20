using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.BankAccounts
{
    class SavingAccount : ABankAccount
    {
        public override void Withdraw(int amount)
        {
            if (Balance - amount <= 500)
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
}
