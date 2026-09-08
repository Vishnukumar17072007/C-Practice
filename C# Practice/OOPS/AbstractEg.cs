using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS
{
    abstract class AbstractEg
    {
        public string Name;
        public AbstractEg(string name) => Name = name;

        public void DispName() => Console.WriteLine("Name: "+Name); //cannot be overrided
        public abstract int DispSalary();
    }
    class Employee : AbstractEg
    {
        public Employee(string name) : base(name) { }
        private int salary = 25000;
        public override int DispSalary()
        {
            return salary;
        }
    }
    class HR : AbstractEg
    {
        public HR(string name) : base(name) { }
        private readonly int salary = 45000;
        public override int DispSalary()
        {
            return salary;
        }
    }
    class SoftwareEngineer : AbstractEg
    {
        public SoftwareEngineer(string name) : base(name) { }
        private int salary = 50000;
        public override int DispSalary()
        {
            return salary;
        }
    }
}
