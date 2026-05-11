using System;

class Program
{
    static void Main()
    {
        int a = 0, b = 1, c;

        Console.Write(a + " " + b + " ");

        for (int i = 1; i <= 8; i++)
        {
            c = a + b;
            Console.Write(c + " ");

            a = b;
            b = c;
        }
    }
}
