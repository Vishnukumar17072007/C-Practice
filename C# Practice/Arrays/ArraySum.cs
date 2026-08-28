using System;

public class ArraySum
{
	public int Sum(int[] arr)
	{
		Console.WriteLine("Sum of numbers in a array");
		int sum = 0;
		for(int i=0; i<arr.Length; i++)
		{
			sum = sum + arr[i];
		}
		Console.WriteLine($"Total : {sum}");
		return sum;
	}
	public float Average(int sum, int[] arr)
	{
		float average = sum / arr.Length;
		Console.WriteLine($"Average: {average}");
		return average;
	}
}
