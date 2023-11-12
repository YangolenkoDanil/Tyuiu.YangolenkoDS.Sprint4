using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint4.Task5.V5.Lib;
namespace Tyuiu.YangolenkoDS.Sprint4.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                         *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                              *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #5                                                                        *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Найти сумму положительных элементов                                               *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int[,] mtrx = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mtrx[i,j] = rnd.Next(-5, 8);
                }
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0;j < 5; j++)
                {
                    Console.Write($"{mtrx[i,j]} \t");
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(mtrx);

            Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Сумма положительных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
