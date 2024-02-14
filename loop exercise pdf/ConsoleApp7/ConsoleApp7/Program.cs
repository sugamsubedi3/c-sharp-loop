using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        int first = 0, second = 1, next;

        Console.Write("Fibonacci sequence: " + first + " " + second + " ");

        for (int i = 3; i <= n; i++)
        {
            next = first + second;
            Console.Write(next + " ");

            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}
