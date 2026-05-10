using System;

class Program
{
    static void Main()
    {
        string str = "madam";
        bool isPalindrome = true;

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                isPalindrome = false;
                break;
            }

            left++;
            right--;
        }

        if (isPalindrome)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}