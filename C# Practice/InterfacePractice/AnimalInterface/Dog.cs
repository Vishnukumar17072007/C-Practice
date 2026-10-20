using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.InterfacePractice.AnimalInterface
{
    class Dog : IAnimal
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
}
