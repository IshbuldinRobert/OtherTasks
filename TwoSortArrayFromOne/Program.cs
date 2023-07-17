using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSortArrayFromOne
{
    /*
     * Задан одномерный массив целых чисел.
     * Образуйте из него два отсортированных по возрастанию массива, содержащих четные и нечетные числа.
     */
    internal class Program
    {
        static int[] QuickSort(int[] nums)
        {
            if (nums.Length <= 1)
                return nums;
            else
            {
                int pivot = nums[0];
                int[] left = nums.Skip(1).Where(x => x < pivot).ToArray();
                int[] right = nums.Skip(1).Where(x => x >= pivot).ToArray();
            
                return QuickSort(left).Concat(new int[] { pivot }).Concat(QuickSort(right)).ToArray();
            }
        }
        static void Main(string[] args)
        {
            int[] ints = { 5, 3, 5, 2, 1, 7, 121, 3, 3, 5, 34, 4, 2, 23 };

            Console.WriteLine("Отсортированный массив: [" + string.Join(", ", QuickSort(ints)) + "]");

            int[] evenInts = ints.Where(x => x % 2 == 0).ToArray();
            int[] unevenInts = ints.Where(x => x % 2 != 0).ToArray();

            Console.WriteLine("Массив с четными элементами: [" + string.Join(", ", QuickSort(evenInts)) + "]");
            Console.WriteLine("Массив с нечетными элементами: [" + string.Join(", ", QuickSort(unevenInts)) + "]");

            Console.ReadLine();
        }
    }
}
