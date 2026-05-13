using System;

class Program
{
    static void Main()
    {
        string str = "education";
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            if (ch == 'a' || ch == 'e' || ch == 'i' ||
                ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' ||
                ch == 'O' || ch == 'U')
            {
                count++;
            }
        }

        Console.WriteLine("Vowel Count: " + count);
    }
}