using System;

class Program
{
    static void Main()
    {
        int[] arr = { 12, 45, 7, 89, 23 };

        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine("Largest Number: " + max);
    }
}