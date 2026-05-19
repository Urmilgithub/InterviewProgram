using System;

class Program
{
    static void Main()
    {
        int n = 4;

        for (int i = 1; i <= n; i++)
        {
            // spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // increasing numbers
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            // decreasing numbers
            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}