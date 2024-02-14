using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer N (N < 20): ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 20 || n <= 0)
        {
            Console.WriteLine("Please enter a positive integer less than 20.");
            return;
        }

        Console.WriteLine($"N = {n}");

        // Generate and print the matrix
        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col <= row + n - 1; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}
