using System;

namespace C__Practice.Array 
{
    public class HighestLowestInArray
    {
        public void Print()
        {
            int[] arr = { 4, 5, 3, 6, 2, 9 };

            int max = arr[0];
            int maxPosition = 0;
            int min = arr[0];
            int minPosition = 0;

            Console.WriteLine("Finding highest and Lowest value and it's position from the Array");
            Console.WriteLine("Original Array : " );
            PrintArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxPosition = i;
                }
                if (min > arr[i])
                {
                    min = arr[i];
                    minPosition = i;
                }
            }

            Console.WriteLine($"Highest value in Array : {max}\nPosition : {maxPosition}");
            Console.WriteLine($"Lowest value in Array : {min}\nPosition : {minPosition}");
        }
        void PrintArray(int[] arr)
        {
            foreach (int j in arr)
            {
                Console.Write(j + ", ");
            }
            Console.WriteLine();
        }

        public MinAndMaxValue FindMinAndMaxValue()
        {
            int[] arr = { 4, 5, 3, 6, 2, 9 };

            int max = arr[0];
            int maxPosition = 0;
            int min = arr[0];
            int minPosition = 0;

            Console.WriteLine("Finding highest and Lowest value and it's position from the Array");
            Console.WriteLine("Original Array : ");
            PrintArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxPosition = i;
                }
                if (min > arr[i])
                {
                    min = arr[i];
                    minPosition = i;
                }
            }

            return new MinAndMaxValue { Min = min, Max = max };
        }
    }

    public class MinAndMaxValue
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }
}