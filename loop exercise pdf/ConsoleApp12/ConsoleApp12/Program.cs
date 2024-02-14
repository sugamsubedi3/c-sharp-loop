using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        int trailingZeros = CountTrailingZerosInFactorial(n);

        Console.WriteLine($"The number of trailing zeros in {n}! is: {trailingZeros}");
    }

    static int CountTrailingZerosInFactorial(int n)
    {
        int count = 0;

        for (int i = 5; n / i >= 1; i *= 5)
        {
            count += n / i;
        }

        return count;
    }
}
