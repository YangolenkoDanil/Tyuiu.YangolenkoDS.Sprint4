﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YangolenkoDS.Sprint4.Task0.V27.Lib
{
    public class DataService : ISprint4Task0V27
    {
        public int GetMultOddArrEl(int[] array)
        {
            int Mult = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Mult *= array[i];
                }
            }
            return Mult; 
        }
    }
}
