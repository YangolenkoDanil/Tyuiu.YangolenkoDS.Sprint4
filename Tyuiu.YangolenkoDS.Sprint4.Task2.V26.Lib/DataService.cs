using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YangolenkoDS.Sprint4.Task2.V26.Lib
{
    public class DataService : ISprint4Task2V26
    {
        public int Calculate(int[] array)
        {
            int Mult = 1;
            for (int i = 0;  i < array.Length - 1; i++)
            {
                if (i > 0 && i < 9 && array[i] % 2 != 0)
                {
                    Mult *= array[i];
                }
            }
            return Mult;
        }
    }
}
