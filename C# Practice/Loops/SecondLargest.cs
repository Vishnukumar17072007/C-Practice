using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Loops
{
    class SecondLargest
    {
        public int find(int[] nums)
        {
            int largest;
            int secondLargest;
            if (nums.Length >= 2)
            {
                largest = nums[0];
                secondLargest = nums[1];
            }
            else
            {
                Console.WriteLine("Insufficient elements unable to find Second largest");
                return -1;
            }
            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i] > largest)
                {
                    secondLargest = largest;
                    largest = nums[i];
                }
                else if (nums[i] > secondLargest && nums[i] != largest)
                {
                    secondLargest = nums[i];
                }
            }
            Console.WriteLine($"Second Largest Element in the Array : {secondLargest}");
            return secondLargest;
        }
    }
}
