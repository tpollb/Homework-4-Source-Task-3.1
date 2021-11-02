using System;

namespace Homework_4_Source_Task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int n = -256;
            int MatrixSize = 1;
            int MinNuber = 0;
            int MaxNuber = 20;

            while (n < -255 || n > 255)
            {
                Console.WriteLine("Введите множитель от -255 до 255: ");
                n = int.Parse(Console.ReadLine());
            }

            while (MatrixSize < 2 || MatrixSize > 255)
            {
                Console.WriteLine("Введите размерность матрицы от 2 до 255: ");
                MatrixSize = int.Parse(Console.ReadLine());
            }

            int[,] matrix = new int[MatrixSize, MatrixSize];
            int[,] MultMatrix = new int[MatrixSize, MatrixSize];

            //заполнение
            var Rand = new Random();

            Console.WriteLine();
            Console.WriteLine("Исходная матрица:");
            Console.WriteLine();

            for (i = 0; i < MatrixSize; i++)
            {
                for (j = 0; j < MatrixSize; j++)
                {
                    matrix[i, j] = Rand.Next(MinNuber, MaxNuber);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            //умножение

            Console.WriteLine();
            Console.WriteLine("Умноженная матрица:");
            Console.WriteLine();

            for (i = 0; i < MatrixSize; i++)
            {
                for (j = 0; j < MatrixSize; j++)
                {
                    MultMatrix[i, j] = matrix[i,j] * n;
                    Console.Write($"{MultMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
