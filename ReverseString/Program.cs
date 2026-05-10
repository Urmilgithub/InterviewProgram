using System;

class Program
{
    static void Main()
    {
        string str = "hello";
        char[] arr = new char[str.Length];

        int j = 0;

        for (int i = str.Length - 1; i >= 0; i--)
        {
            arr[j] = str[i];
            j++;
        }

        string reversed = new string(arr);

        Console.WriteLine(reversed);
    }
}