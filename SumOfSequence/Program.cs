using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSequence
{
    /*
     * Вычислите сумму членов последовательности, в которой каждый следующий член в три раза меньше предыдущего,
     * начиная с единицы, т.е.: S=1+1/3+1/9+1/27+… с погрешностью 10^-3.
     */
    internal class Program
    {
        static double SumSequence(double firstNum)
        {
            double sum = firstNum;
            double slag = firstNum;
            uint c = 3;

            Console.Write("Sum = " + sum);
            for (int i = 0; i < 5; i++)
            {
                Console.Write($" + {firstNum}/{c}");
                slag /= 3;
                sum += slag;
                c *= 3;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый член последовательности: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("\nСумма последовательности: " + Math.Round(SumSequence(firstNum), 3));
        }
    }
}
