using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.InterfacePractice
{
    public interface CarBluerint
    {
        void body();
        void interior();
        void sideDoors();
        void windShieldGlasses();
        void exterior();
        void wheels();
    }
    class CarAssembling : CarBluerint
    {
        public void body()
        {
            Console.WriteLine("Body Assembled.");
        }
        public void interior()
        {
            Console.WriteLine("Interior wrok done.");
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
            Console.WriteLine("Four wheels fited.");
        }
    }
}
