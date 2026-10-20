using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C__Practice.InterfacePractice.AnimalInterface
{
    interface IAnimal
    {
        string Name { get; set; }
        string Type { get; set; }
        public void Sound() => Console.WriteLine("Bow! Bow!"); //can be overrided
        public void Details();
    }
}
