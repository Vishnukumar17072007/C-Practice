using System;
using System.Collections.Generic;

namespace C__Practice.Array
{
    class Slicing
    {
        public List<string> Slice(string str, char separator)
        {
            //Console.WriteLine("Slicing String to Array by Separator");

            List<string> arr = new List<string>();
            string join = "";

            //Console.Write("Enter Sequence of strings : ");
            //string str = Console.ReadLine();
            //Console.Write("Enter char where to slice : ");
            //char separator = Console.ReadLine()[0];

            foreach (char c in str)
            {
                if (c != separator)
                {
                    join = join + c;
                }
                else
                {
                    arr.Add(join);
                    join = "";
                }
            }   
            arr.Add(join);
            Console.WriteLine($"Original String : {str}");
            Console.WriteLine($"String to Array : {string.Join(", ", arr)}");

            return arr;
        }
    }
}