using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace C__Practice.Basics
{
    class FizzBuzz
    {
        public void Start(int n)
        {
            string word = "";
            for(int i=1; i <= n; i++)
            {
                if(i%3 == 0)
                {
                    word = "fizz";
                }
                else if (i%5 == 0)
                {
                    word = "buzz";
                }
                if(i%15 == 0)
                {
                    word = "fizzbuzz";
                }
                switch (word)
                {
                    case "fizz":
                        Console.WriteLine("fizz");
                        word = "";
                        break;
                    case "buzz":
                        Console.WriteLine("buzz");
                        word = "";
                        break;
                    case "fizzbuzz":
                        Console.WriteLine("fizzbuzz");
                        word = "";
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }
    }
}
