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

        Console.WriteLine("Матрица (5x5):");
        PrintMatrix(matrix);

        
        int[] bArray = GetRowNegativeFlagArray(matrix);

        Console.WriteLine("\nB массиві (әр жолда теріс элементтің бар-жоғы: 1 - бар, 0 - жоқ):");
        Console.WriteLine(string.Join(", ", bArray));
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }
    }
    static int[] GetRowNegativeFlagArray(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] b = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            bool hasNegative = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] < 0)
                {
                    hasNegative = true;
                    break; 
                }
            }
            b[i] = hasNegative ? 1 : 0;
        }

        return b;
    }
}