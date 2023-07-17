using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWordsInTheText
{
    /*
     * В заданной строке текста определите количество слов. Каждое слово отделено друг от друга пробелом.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // работает коряво
            string str = Console.ReadLine();
            uint count = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str[i] == ' ') && (str[i + 1] != ' '))
                    count++;
            }
            Console.WriteLine("Количество слов в тексте: " + count);
        }
    }
}
