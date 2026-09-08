using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C__Practice.OOPS
{
    interface IInterfaceEg
    {
        string Name { get; set; }
        string Type { get; set; }
        public void Sound() => Console.WriteLine("Bow! Bow!"); //can be overrided
        public void Details();
    }

    class Dog : IInterfaceEg
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Dog(string name)
        {
            Name = name;
            Type = "Pet";
        }

        //public void Sound()
        //{
        //    Console.WriteLine("Bow! Bow!");
        //}

        public void Details()
        {
            Console.WriteLine($"{Name} is a {Type} Animal");
            //Sound();
        }
    }

    class Lion : IInterfaceEg
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Lion(string name)
        {
            Name = name;
            Type = "Domestic";
        }
        public void Sound()
        {
            Console.WriteLine("Rrrrr!!!");
        }
        public void Details()
        {
            Console.WriteLine($"{Name} is a {Type} Animal");
            //Sound();
        }
    }
}
