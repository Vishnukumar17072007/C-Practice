using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.EmpDetails
{
    class SoftwareEngineer : AEmpDetails
    {
        public SoftwareEngineer(string name) : base(name) { }
        private int salary = 50000;
        public override int DispSalary()
        {
            return salary;
        }
    }
}
