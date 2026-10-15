using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.ArrayListPractice
{
    class ArrayListDetails
    {
        public void run()
        {
            ArrayList arr = new ArrayList();
            Console.Write("Enter S.NO: ");
            int no = int.Parse(Console.ReadLine());
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Mark: ");
            double mark = double.Parse(Console.ReadLine());
            arr.Add(no);
            arr.Add(name);
            arr.Add(mark);
            foreach (var value in arr)
            {
                Console.WriteLine(value);
            }
        }
    }
}
