using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Loops
{
    class RotateArray
    {
        public int[] Rotate(int[] arr, int left, int right)
        {
            int len = arr.Length;
            int[] RotatedArr = new int[len];
            int count = 0;

            if(left < 0 || right < 0 || left > len-1 || right > len-1 || len == 0)
            {
                Console.WriteLine("Invalid input!");
                return [];
            }
            else if(left > 0)
            {
                for(int i=left; i < len; i++)
                {
                    RotatedArr[count++] = arr[i];
                }
                for(int j = 0; j<left; j++)
                {
                    RotatedArr[count++] = arr[j];
                }
            }
            else if (right > 0)
            {
                count = 0;
                for (int i = len - right; i < len; i++)
                {
                    RotatedArr[count++] = arr[i];
                }
                for (int j = 0; j < len - right; j++)
                {
                    RotatedArr[count++] = arr[j];
                }
            }
            else
            {
                return arr;
            }

            return RotatedArr;
        }
    }
}
