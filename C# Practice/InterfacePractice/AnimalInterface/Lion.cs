using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.InterfacePractice.AnimalInterface
{
    class Lion : IAnimal
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
