using System;

class Program
{
    static void Main()
    {
        int nomer = 5;
        int n = 5;

        int[,] matrix = new int[n, n];
        Random rnd = new Random(nomer);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.Next(-10, 11);
            }
        }

        Console.WriteLine("Бастапқы матрица:");
        PrintMatrix(matrix);

        int[] B = FindNegativeRows(matrix);

        Console.WriteLine("\nB массиві:");
        for (int i = 0; i < B.Length; i++)
        {
            Console.Write(B[i] + " ");
        }
    }

    static void PrintMatrix(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write($"{m[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    static int[] FindNegativeRows(int[,] m)
    {
        int[] B = new int[m.GetLength(0)];

        for (int i = 0; i < m.GetLength(0); i++)
        {
            B[i] = 0;

            for (int j = 0; j < m.GetLength(1); j++)
            {
                if (m[i, j] < 0)
                {
                    B[i] = 1;
                    break;
                }
            }
        }

        return B;
    }
}