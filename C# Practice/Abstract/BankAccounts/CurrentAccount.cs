using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.BankAccounts
{
    class CurrentAccount : ABankAccount
    {
        public override void Withdraw(int amount)
        {
            if (amount > Balance + 1000) //here 1000 represents overdraft amount which is setted by banks that user can borrow money from the bank upto a limit. The balance goes to negative
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
