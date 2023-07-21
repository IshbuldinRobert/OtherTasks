using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator
{
    /*
     * Составьте процедуры, которые бы вычисляли сумму и произведение двух матриц
     * (не обязательно квадратных) с проверкой размерностей.
     */
    internal class Program
    {
        /// <summary>
        /// Заполняет матрицу
        /// </summary>
        /// <param name="matrix"></param>
        static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine((i + 1) + " строка:");
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"[a{i}, b{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        /// <summary>
        /// Выводит матрицу на экран
        /// </summary>
        /// <param name="matrix"></param>
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Вычисляет сумму двух матриц, возвращет новую матрицу
        /// </summary>
        /// <param name="firstMatrix"></param>
        /// <param name="secondMatrix"></param>
        /// <returns></returns>
        static int[,] SumMatrix(int[,] firstMatrix, int[,] secondMatrix)
        {
            int[,] sumMatrix = new int[firstMatrix.GetLength(0),firstMatrix.GetLength(1)];

            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }
            return sumMatrix;
        }
        /// <summary>
        /// Вычисляет произведение матриц, возвращает новую матрицу
        /// </summary>
        /// <param name="firstMatrix"></param>
        /// <param name="secondMatrix"></param>
        /// <returns></returns>
        static int[,] ProductMatrix(int[,] firstMatrix, int[,] secondMatrix) 
        {
            int[,] productMatrix = new int[firstMatrix.GetLength(0),secondMatrix.GetLength(1)];

            for ( int i = 0;i < firstMatrix.GetLength(0); i++) // бежим по строке матрицы 1
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++) // бежим по столбцу матрицы 2
                {
                    for (int k = 0; k < firstMatrix.GetLength(1); k++) // количество слагаемых произведений = эелемент матрицы 3
                    {
                        productMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }
            return productMatrix;
        }
        static void Main(string[] args)
        {
            Console.Title = "Калькулятор матриц";
            char again = 'Y';
            while (again == 'Y')
            {
                Console.Write("Кол-во строк матрицы 1: ");
                uint row1 = uint.Parse(Console.ReadLine());
                Console.Write("Кол-во столбцов матрицы 1: ");
                uint column1 = uint.Parse(Console.ReadLine());
                int[,] matrix1 = new int[row1, column1];
                FillMatrix(matrix1);

                Console.Write("Кол-во строк матрицы 2: ");
                uint row2 = uint.Parse(Console.ReadLine());
                Console.Write("Кол-во столбцов матрицы 2: ");
                uint column2 = uint.Parse(Console.ReadLine());
                int[,] matrix2 = new int[row2, column2];
                FillMatrix(matrix2);

                Console.WriteLine("\n\tПолученные матрицы");
                Console.WriteLine("Матрица 1:");
                PrintMatrix(matrix1);
                Console.WriteLine("\nМатрица 2:");
                PrintMatrix(matrix2);

                Console.WriteLine("\n\tСУММА МАТРИЦ");
                if (row1 == row2 && column1 == column2)
                {
                    int[,] sumMatrix = SumMatrix(matrix1, matrix2);
                    PrintMatrix(sumMatrix);
                }
                else Console.WriteLine("Нельзя вычислить сумму матриц неодинакового размера!");

                Console.WriteLine("\n\tПРОИЗВЕДЕНИЕ МАТРИЦ");
                if (column1 == row2)
                {
                    int[,] productMatrix = ProductMatrix(matrix1, matrix2);
                    PrintMatrix(productMatrix);
                }
                else Console.WriteLine("Кол-во столбцов первой матрицы не равно кол-ву строк второй! Произведение невозможно!");

                Console.WriteLine("Введите 'Y', если хотите еще воспользоваться кулькулятором, для выхода нажмите любую клавишу");
                again = char.Parse(Console.ReadLine());
            }
        }
    }
}