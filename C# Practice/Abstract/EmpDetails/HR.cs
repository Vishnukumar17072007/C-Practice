using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.EmpDetails
{
    class HR : AEmpDetails
    {
        public HR(string name) : base(name) { }
        private readonly int salary = 45000;
        public override int DispSalary()
        {
            return salary;
        }
    }
}
