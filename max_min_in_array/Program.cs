using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_min_in_array
{
    /*
     * В заданном массиве действительных чисел найдите разность между максимальным и минимальным числом.
     */
    internal class Program
    {
        /// <summary>
        /// Метод возвращает разницу между максимальным и минимальным элементами массива.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int MaxMinInArray(int[] array)
        {
            int max = array[0],
                min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                else if (array[i] > max)
                    max = array[i];
            }
            return max - min;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int length = int.Parse(Console.ReadLine());
            int[] ints = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
                ints[i] = random.Next(100);

            Console.WriteLine(string.Join(", ", ints));

            Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + MaxMinInArray(ints));

            Console.ReadLine();
        }
    }
}
