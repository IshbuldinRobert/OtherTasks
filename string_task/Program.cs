using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_task
{
    /*
     *  Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.
     */
    internal class Program
    {
        /// <summary>
        /// Возвращает значение типа char, введенное с клавиатуры в консоль.
        /// </summary>
        /// <returns></returns>
        static char InputChar()
        {
            return char.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Возвращает значение типа string, введенное с клавиатуры в консоль
        /// </summary>
        /// <returns></returns>
        static string InputString()
        {            
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string str = InputString();

            Console.Write("Процент вхождения какого символа нужно подсчитать: ");
            char simbol = InputChar();

            uint count = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == simbol)
                {
                    count++;
                }
            }

            //double inputProcent = Convert.ToDouble(count) / str.Length * 100;

            Console.WriteLine("Количество символов в тексте: " + str.Length);
            Console.WriteLine("Процент вхождения символа '" + simbol + "' в веденном тексте равен " + Math.Round(Convert.ToDouble(count) / str.Length * 100, 3) + " %.");

            Console.ReadLine();
        }
    }
}
