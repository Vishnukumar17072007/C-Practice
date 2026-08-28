using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Arrays
{
    class IndexOf
    {
        public int Find(string str, string substr)
        {
            int count = 0;
            for(int i = 0; i < str.Length; i++ )
            {
                if (str[i] == substr[count])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == substr.Length)
                {
                    return (i - (count - 1));
                }
            }

            return -1;
        }
    }
}
