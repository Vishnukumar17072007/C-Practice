using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Arrays
{
    class Contains
    {
        public bool Find(string mainstring, string substring) {
            IndexOf str = new IndexOf();
            int index = str.Find(mainstring, substring);

            if(index < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
