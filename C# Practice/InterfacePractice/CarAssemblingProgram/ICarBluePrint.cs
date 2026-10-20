using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.InterfacePractice.CarAssemblingProgram
{
    public interface ICarBluePrint
    {
        void body();
        void interior();
        void sideDoors();
        void windShieldGlasses();
        void exterior();
        void wheels();
    }
}
