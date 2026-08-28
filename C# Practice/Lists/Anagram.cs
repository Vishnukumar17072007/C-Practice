using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Lists
{
    class Anagram
    {
        public bool find(string str1, string str2)
        {
            List<char> characters = new List<char>();
            if (str1.Length != str2.Length)
            {
                return false;
            }
            for(int i = 0; i<str1.Length; i++)
            {
                characters.Add(str1[i]);
            }

            for(int i=0; i<str2.Length; i++)
            {
                if (characters.Contains(str2[i]))
                {
                    characters.Remove(str2[i]);
                }
            }

            if(characters.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}
