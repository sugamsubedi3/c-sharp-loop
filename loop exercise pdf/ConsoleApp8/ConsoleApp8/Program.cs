using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        int gcd = FindGCD(a, b);

        Console.WriteLine($"The GCD of {a} and {b} is: {gcd}");
    }

    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}
