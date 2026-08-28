using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Arrays
{
    class LongestWord
    {
        public string FindLnString(string str)
        {
            string Lnword = "";
            string tempStr = "";
            int wordLen = Lnword.Length;

            foreach(char ch in str)
            {
                if (ch == ' ')
                {
                    if(tempStr.Length > wordLen)
                    {
                        Lnword = tempStr;
                        wordLen = Lnword.Length;
                    }
                    tempStr = "";
                }
                else
                {
                    tempStr = tempStr + ch;
                }
            }

            return Lnword;
        }
    }
}
