class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}