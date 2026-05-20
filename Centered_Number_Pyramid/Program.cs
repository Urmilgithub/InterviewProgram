using System;

class Program
{
    static void Main()
    {
        int rows = 4;

        for (int i = 1; i <= rows; i++)
        {
            for (int s = 1; s <= rows - i; s++)
                Console.Write(" ");

            for (int j = 1; j <= (2 * i - 1); j++)
                Console.Write(i);

            Console.WriteLine();
        }
    }
}