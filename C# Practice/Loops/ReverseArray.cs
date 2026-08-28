using System;

namespace C__Practice.Loops
{
    class ReverseArray
    {
        public string Reverse(string str)
        {
            string strRev = "";
            foreach(int i in str)
            {
                strRev = i + strRev;
            }
            return strRev;
        }
    }

    
}
