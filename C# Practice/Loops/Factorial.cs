using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Loops
{
    class Factorial
    {
        public int Factorials(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorials(n - 1);
            }
        }
    }
}
