using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPs
{
    class Car : Vehicles
    {
        public Car(string brandName, string modelName, string type, int hp, string engineType, int speed, int seats) : base(brandName, modelName, type, hp, engineType, speed, seats) { }

        public void Car_Type()
        {
            Console.WriteLine("Type of car: " + Type);
        }
        public void HorsePower()
        {
            Console.WriteLine("This car have "+ HP + "hp.");
        }
        public void Engine_Type()
        {
            Console.WriteLine("This car holds " + EngineType + " Engine.");
        }
        public void CarDetails()
        {
            VehicleName();
            Car_Type();
            HorsePower();
            Engine_Type();
            Speed();
            Seats();
        }
    }
}
