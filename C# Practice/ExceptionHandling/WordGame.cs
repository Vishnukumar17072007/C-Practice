using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace C__Practice.ExceptionHandling
{
    public class WordGame
    {
        public void Start(string word)
        {
            try
            {
                string smallCaseWord = word.ToLower();
                switch (smallCaseWord)
                {
                    case "hi":
                        throw new Exception("Don't say it again!!");
                    case "hello":
                        throw new Exception("Don't say it again!!");
                    case "hey":
                        throw new Exception("Don't say it again!!");
                    case "what's up":
                        throw new Exception("Don't say it again!!");
                    case "mm":
                        throw new Exception("Don't say it again!!");
                    default:
                        Console.WriteLine("You just won!");
                        break;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
