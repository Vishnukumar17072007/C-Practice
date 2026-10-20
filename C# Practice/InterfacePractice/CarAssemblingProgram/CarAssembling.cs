using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.InterfacePractice.CarAssemblingProgram
{
    
    class CarAssembling : ICarBluePrint
    {
        public void body()
        {
            Console.WriteLine("Body Assembled.");
        }
        public void interior()
        {
            Console.WriteLine("Interior work done.");
        }
        public void sideDoors()
        {
            Console.WriteLine("Side doors attached.");
        }
        public void windShieldGlasses()
        {
            Console.WriteLine("Windshield glasses fited in the doors.");
        }
        public void exterior()
        {
            Console.WriteLine("Exterior work done.");
        }
        public void wheels()
        {
            Console.WriteLine("Four wheels fitted.");
        }
    }
}
