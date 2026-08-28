using System;

namespace C__Practice.Pattern
{
    public class HallowSquare
    {
        public void Print()
        {
            Console.WriteLine("Hallow Square");
            for( int i = 1; i<5; i++)
            {
                for(int j=1; j<5; j++)
                {
                    if (i == 1 || i == 4)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        if(j==1 || j==4)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}