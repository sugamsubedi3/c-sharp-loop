using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        long catalanNumber = CalculateCatalanNumber(n);

        Console.WriteLine($"The {n}th Catalan number is: {catalanNumber}");
    }

    static long CalculateCatalanNumber(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        long result = 0;

        for (int i = 0; i < n; i++)
        {
            result += CalculateCatalanNumber(i) * CalculateCatalanNumber(n - i - 1);
        }

        return result;
    }
}
