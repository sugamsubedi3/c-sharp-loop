using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of X: ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            double factorial = 1;

            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }

            sum += factorial / Math.Pow(x, i);
        }

        Console.WriteLine($"The sum S is: {sum}");
    }
}
