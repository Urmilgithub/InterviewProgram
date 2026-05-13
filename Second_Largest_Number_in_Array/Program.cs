using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 50, 30, 80, 60 };

        int largest = arr[0];
        int secondLargest = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }

        Console.WriteLine("Second Largest: " + secondLargest);
    }
}