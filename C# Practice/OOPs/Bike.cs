using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPs
{
    class Bike : Vehicles
    {
        public Bike(string brandName, string modelName, string type, int hp, string engineType, int speed, int seats) : base(brandName, modelName, type, hp, engineType, speed, seats) { }

        public void Bike_Type()
        {
            Console.WriteLine("Bike type: " + Type);
        }
        public void HorsePower()
        {
            Console.WriteLine("This Bike can produce " + HP + "hp.");
        }
        public void Engine_Type()
        {
            Console.WriteLine("This Bike holds " + EngineType + " Engine.");
        }
        public void BikeDetails()
        {
            VehicleName();
            Bike_Type();
            HorsePower();
            Engine_Type();
            Speed();
            Seats();
        }
    }
}
