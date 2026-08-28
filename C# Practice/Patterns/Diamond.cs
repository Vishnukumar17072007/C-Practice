using System;
using System.Linq;

namespace C__Practice.Pattern
{
    public class Diamond
    {
        public void Print()
        {
            int space = 5;
            int j = 0;
            Console.WriteLine("Diamonds Pattern");

            for (int i = 1; i < 10; i++)
            {
                if (i > 5)
                {
                    space++;
                    j--;
                }
                else
                {
                    space--;
                    j++;
                }
                Console.WriteLine(string.Concat(Enumerable.Repeat(" ", space)) + string.Concat(Enumerable.Repeat("* ", j)));
            }
        }
    }
}