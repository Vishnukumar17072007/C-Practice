using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.EmpDetails
{
    abstract class AEmpDetails
    {
        public string Name;
        public AEmpDetails(string name) => Name = name;

        public void DispName() => Console.WriteLine("Name: " + Name); //cannot be overrided
        public abstract int DispSalary();
    }
}
