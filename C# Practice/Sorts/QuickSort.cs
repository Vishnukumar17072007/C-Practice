using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Sort
{
    class QuickSort
    {
        public void sort(int[] arr, int left, int right)
        {
            if(left >= right)
            {
                return;
            }

            int pivot = right;
            int pivotValue = arr[pivot];
            int pivotPosition = left;
            int temp;

            for(int i = left; i < right; i++)
            {
                if (arr[i] < pivotValue)
                {
                    temp = arr[i];
                    arr[i] = arr[pivotPosition];
                    arr[pivotPosition] = temp;

                    pivotPosition++;
                }
            }

            temp = arr[pivotPosition];
            arr[pivotPosition] = pivotValue;
            arr[pivot] = temp;
            Console.Write(string.Join(" ,", arr) + "\n");

            sort(arr, left, pivotPosition - 1);
            sort(arr, pivotPosition + 1, right);
        }
    }
}
