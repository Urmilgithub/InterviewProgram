using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40 };
        int search = 30;
        int found = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == search)
            {
                found = 1;
                break;
            }
        }

        if (found == 1)
            Console.WriteLine("Element Found");
        else
            Console.WriteLine("Element Not Found");
    }
}