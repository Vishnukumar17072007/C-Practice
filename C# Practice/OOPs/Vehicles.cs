using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPs
{
    class Vehicles
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }
        public string EngineType { get; set; }
        public int TopSpeed { get; set; }
        public int SeaterCount { get; set; }

        public Vehicles(string brandName, string modelName, string type, int hp, string engineType, int topSpeed, int seats)
        {
            BrandName = brandName;
            ModelName = modelName;
            Type = type;
            HP = hp;
            EngineType = engineType;
            TopSpeed = topSpeed;
            SeaterCount = seats;
        }
        public void VehicleName()
        {
            Console.WriteLine($"Car name: {BrandName} {ModelName}");
        }
        public void Speed()
        {
            Console.WriteLine("Top speed of this car: " + TopSpeed + "km/h.");
        }
        public void Seats()
        {
            Console.WriteLine("This car have " + SeaterCount + " seats.\n");
        }
    }
}
