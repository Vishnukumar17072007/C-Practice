using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPS.EmpDetails
{
    class Intern : AEmpDetails
    {
        public Intern(string name) : base(name) { }
        private int salary = 25000;
        public override int DispSalary()
        {
            return salary;
        }
    }
}
