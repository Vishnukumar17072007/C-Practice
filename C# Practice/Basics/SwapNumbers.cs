using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Basics
{
    class SwapNumbers
    {
        public SwappedNumbers swap(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            return new SwappedNumbers { Num1 = num1, Num2 = num2 };
        }
    }

    public class SwappedNumbers()
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    }
}
