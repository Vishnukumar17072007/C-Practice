using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Dictionaries
{
    class EmpAndRole
    {
        private Dictionary<string, string> emps = new Dictionary<string, string>();
        public void AddOrModifyEmpAndRole(string Name, string Role)
        {
            emps[Name] = Role;
            //emp.Add(key, value);
        }
        public void RemoveEmpAndRoleByKey(string Name)
        {
            if (isContainsKey(Name))
            {
                emps.Remove(Name);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }
        public bool isContainsKey(string Name)
        {
            return emps.ContainsKey(Name);
        }
        public void ShowAllEmpAndRoles()
        {
            foreach (KeyValuePair<string, string> emp in emps)
            {
                Console.WriteLine($"{emp.Key} is {emp.Value}");
            }
        }
    }
}
