using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_10x10
{
    /*
     * Задан массив действительных чисел размерности 10х10.
     * Найти суммы элементов каждой строки, произведения элементов каждого столбца,
     * и максимальный элемент главной диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца).
     */
    internal class Program
    {
        static Random rnd = new Random();
        /// <summary>
        /// Метод принимает на вход матрицу и выводит её в консоль.
        /// </summary>
        /// <param name="matrix"></param>
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Метод заполнения матрицы. Принимает на вход матрицу, ничего не возвращает.
        /// </summary>
        /// <param name="matrix"></param>
        static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }
        }
        /// <summary>
        /// Принимает на вход матрицу, возвращает массив, элементами которого являются суммы элементов каждой строки матрицы.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static int[] SumInString(int[,] matrix)
        {
            int[] sums = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sums[i] += matrix[i, j];
                }
            }

            return sums;
        }
        /// <summary>
        /// Принимает на вход матрицу, возвращает массив, элементами которого являются произведения элементов каждого столбца матрицы.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static int[] ProductInColumn(int[,] matrix)
        {
            int[] prods = new int[matrix.GetLength(1)];
            for (int n = 0; n < prods.Length; n++)
            {
                prods[n] = 1;
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    prods[i] *= matrix[j, i];
                }
            }

            return prods;
        }
        /// <summary>
        /// Находит максимальный элемент главной диагонали матрицы, которую принимает на вход. Возвращает значение этого элемента.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static int MaxElementOfMainDiagonal(int[,] matrix)
        {
            int max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j == i; j++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.Title = "Work_with_matrix";

            int[,] ints = new int[5, 5];

            FillMatrix(ints);
            PrintMatrix(ints);
            Console.WriteLine("\nСумма элементов каждой строки в виде массива: [" + string.Join(", ", SumInString(ints)) + "]");
            Console.WriteLine("Произведение элементов каждого столбца в виде массива: [" + string.Join(", ", ProductInColumn(ints)) + "]");
            Console.WriteLine("\nМаксимальный элемент главной диагонали: " + MaxElementOfMainDiagonal(ints));

            Console.ReadLine();
        }
    }
}