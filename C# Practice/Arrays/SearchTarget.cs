using System;
using System.Collections.Generic;

namespace C__Practice.Array
{
    class SearchTarget
    {
        public int Search(string[] arr, string target)
        {
            Console.WriteLine("Searching Target in Array");

            for(int i =0; i<arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    Console.WriteLine($"Target found at index : {i}");
                    return i;
                }
            }
            Console.WriteLine("Target not found");
            return -1;
        }
    }
}