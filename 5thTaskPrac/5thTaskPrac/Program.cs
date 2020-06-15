using System;

namespace _5thTaskPrac
{
    class Program
    {
        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
            }
        }
        public static Random rnd = new Random();
        static int[,] CreateMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = rnd.Next(-100, 100);
                }
            }
            return matrix;
        }
        static int FindMax(int[,] matrix, int n)
        {
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i>=j && i+j>=n-1)
                    if (matrix[i, j] > max) max = matrix[i, j];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n-ранг матрицы");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int max = 0;
            CreateMatrix(matrix, n);
            PrintMatrix(matrix, n);
            max = FindMax(matrix, n);
            Console.WriteLine(max);
                
        }
    }
}
