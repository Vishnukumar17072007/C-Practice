using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.SortedListPractice
{
    class sortedEmployeeData
    {
        public void run()
        {
            SortedList employeeData = new SortedList();
            employeeData.Add(1001, "Vishnu");//it stores the value as object
            employeeData.Add(1003, "Sridhar");
            employeeData.Add(1002, "Tharmesh");

            foreach(var emp in employeeData.Keys)//but will return the value in sorted order based on keys
            {
                Console.WriteLine(emp + " is " + employeeData[emp]);
            }
        }
    }
}
