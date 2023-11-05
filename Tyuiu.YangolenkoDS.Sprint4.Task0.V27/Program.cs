using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint4.Task0.V27.Lib;

namespace Tyuiu.YangolenkoDS.Sprint4.Task0.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                         *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                       *");
            Console.WriteLine("* Задание #0                                                                        *");
            Console.WriteLine("* Вариант #27                                                                       *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Подсчитать произведение нечетных элементов массива.                               *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetMultOddArrEl(array);

            Console.WriteLine("Массив = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 }");

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Произведение нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
