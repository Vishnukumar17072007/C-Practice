using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.HashTable
{
    class EmployeeData
    {
        public void run()
        {
            Hashtable empdata = new Hashtable(); 
            empdata.Add(1001, "Vishnu");//it store keys and values as object
            empdata.Add(1002, "Kumar");
            empdata.Add(1003, "Sridhar");
            empdata.Add(1004, "Tharmesh");

            foreach(var empNo in empdata.Keys)
            {
                Console.WriteLine(empNo + " is " + empdata[empNo]);// hashtable return values in random order
            }
        }
    }
}
