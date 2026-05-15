using System;

class Program
{
    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Not Anagram");
            return;
        }

        int count = 0;

        for (int i = 0; i < str1.Length; i++)
        {
            for (int j = 0; j < str2.Length; j++)
            {
                if (str1[i] == str2[j])
                {
                    count++;
                    break;
                }
            }
        }

        if (count == str1.Length)
            Console.WriteLine("Anagram");
        else
            Console.WriteLine("Not Anagram");
    }
}