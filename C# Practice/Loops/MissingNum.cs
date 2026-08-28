using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Loops
{
    class MissingNum
    {
        public void Find(int[] num)
        {
            int maxEle = num[0];
            for(int i = 0; i<num.Length; i++)
            {
                if (num[i] > maxEle)
                {
                    maxEle = num[i];
                }
            }

            for(int i = 1; i<maxEle; i++)
            {
                bool isPresent = false;
                for(int j = 0; j< num.Length; j++)
                {
                    if (num[j] == i)
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (!isPresent) {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}
