using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountElementsInArrayWhere
{
    /*
     * В одномерном массиве из 100 чисел M[] подсчитайте количество элементов, удовлетворяющих условию 0 < M[i] <125.
     */
    internal class Program
    {
        static int InputNumber()
        {
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        static Random ran = new Random();
        static void FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(150);
            }
        }
        static int CountElementsWhere(int[] arr)
        {
            int count = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] < 125 && arr[i] > 0)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int lengthArray = InputNumber();
            int[] ints = new int[lengthArray];

            FillArray(ints);
            Console.WriteLine("[" + string.Join(", ", ints) + "]");

            Console.WriteLine("Элементов, удовлетворяющих условию 0 < M[i] < 125 в массиве: " + CountElementsWhere(ints));
        }
    }
}
