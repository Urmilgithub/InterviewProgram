using System;

class Program
{
    static void Main()
    {
        int n = 4;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}