using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basics
{
    class PrimeNumber
    {
        public void PrintPrimeNumbers(int n)
        {
            for(int i=2; i<=n; i++)
            {
                bool isPrimeNumber = true;
                int ConditionValue = (i / 2) + 1;
                //Console.WriteLine(ConditionValue + "    " + i);
                for (int j = 2; j < ConditionValue; j++)
                {
                    if(i%j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                if (isPrimeNumber)
                {
                    Console.WriteLine($"{i} is prime number");
                }
            }
        }
    }
}
