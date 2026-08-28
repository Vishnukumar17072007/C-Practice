using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Sorts
{
    class SelectionSort
    {
        public int[] Sort(int[] nums)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j=i+1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            return nums;
        }
    }
}
