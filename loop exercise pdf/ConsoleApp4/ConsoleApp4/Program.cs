using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of K (K > N): ");
        int k = int.Parse(Console.ReadLine());

        long result = 1;

        for (int i = n + 1; i <= k; i++)
        {
            result *= i;
        }

        Console.WriteLine($"N!/K! = {result}");
    }
}
