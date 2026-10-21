using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.OOPs
{
    class Showroom
    {
        private List<Vehicles> vehicles = new List<Vehicles>();
        public void AddVehicle(Vehicles v)
        {
            vehicles.Add(v);
        }

        public void DisplayCars()
        {
            Console.WriteLine("Total Cars in the Showroom");
            foreach (Car c in vehicles.OfType<Car>())
            {
                c.CarDetails();
            }
        }
        public void DisplayBike()
        {
            Console.WriteLine("\n\nTotal Bikes in the Showroom");
            foreach (Bike b in vehicles.OfType<Bike>())
            {
                b.BikeDetails();
            }
        }
    }
}
