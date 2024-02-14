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

        int[,] spiralMatrix = GenerateSpiralMatrix(n);

        PrintMatrix(spiralMatrix);
    }

    static int[,] GenerateSpiralMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        int currentNumber = 1;

        int top = 0, bottom = n - 1, left = 0, right = n - 1;

        while (currentNumber <= n * n)
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = currentNumber++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = currentNumber++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                matrix[bottom, i] = currentNumber++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                matrix[i, left] = currentNumber++;
            }
            left++;
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }
    }
}
