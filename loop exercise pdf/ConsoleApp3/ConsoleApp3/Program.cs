using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int currentNumber = int.Parse(Console.ReadLine());

            min = Math.Min(min, currentNumber);
            max = Math.Max(max, currentNumber);
        }

        Console.WriteLine($"Min: {min}, Max: {max}");
    }
}
