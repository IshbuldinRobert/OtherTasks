using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_array
{
    internal class Program
    {
        static int[] QuickSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr;
            }
            else
            {
                int pivot = arr[0];
                int[] left = arr.Skip(1).Where(x => x < pivot).ToArray();
                int[] right = arr.Skip(1).Where(x => x >= pivot).ToArray();

                return QuickSort(left).Concat(new int[] { pivot }).Concat(QuickSort(right)).ToArray();
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 7, 2, 5, 9, 3, 0, 3, 4, 5, 1, };
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(string.Join(", ", QuickSort(array)));
        }
    }
}
