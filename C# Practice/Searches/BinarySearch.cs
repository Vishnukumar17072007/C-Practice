using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Searches
{
    class BinarySearch
    {
        public int IterativeSearch(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length;

            while(low <= high)
            {
                int mid = (low + high) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }

        public int RecursiveSearch(int[] nums, int target, int low, int high)
        {
            if(low > high)
            {
                return -1;
            }

            int mid = (low + high) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                return RecursiveSearch(nums, target, low, mid - 1);
            }
            else
            {
                return RecursiveSearch(nums, target, mid + 1, high);
            }
        }
    }
}
