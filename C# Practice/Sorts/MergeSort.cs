using System;
using System.Collections.Generic;

namespace C__Practice.Sort
{
    class MergeSort
    {
        void arrayTransfer(int[] ReplacingArray, int[] ArrayToReplace, int left)
        {
            for(int i = 0; i<ReplacingArray.Length; i++)
            {
                ArrayToReplace[left + i] = ReplacingArray[i];
            }
        }

        void Merge(int[] arr, int left, int mid, int right)
        {
            int arrayStorage = right - left + 1;
            int[] temp = new int[arrayStorage];
            int i, j, k;
            i = left;
            j = mid + 1;
            k = 0;

            while(i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            while(i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }
            while(j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            arrayTransfer(temp, arr, left);
        }
        
        public void Merge_Sort(int[] arr, int left, int right)
        {
            int mid = left + (right - left) / 2;

            if(left < right)
            {
                Merge_Sort(arr, left, mid);
                Merge_Sort(arr, mid+1, right);

                Merge(arr, left, mid, right);
            }
        }
    }
}
