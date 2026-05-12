class Program
{
    static void Main()
    {
        int num = 153;
        int temp = num;
        int sum = 0;

        while (num > 0)
        {
            int rem = num % 10;
            sum = sum + (rem * rem * rem);
            num = num / 10;
        }

        if (temp == sum)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not Armstrong");
    }
}