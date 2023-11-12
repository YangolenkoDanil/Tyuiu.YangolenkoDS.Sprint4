using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.YangolenkoDS.Sprint4.Task7.V10.Lib
{
    public class DataService : ISprint4Task7V10
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            int summ = 0;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (mtrx[i,j] % 2 != 0)
                    {
                        summ += mtrx[i, j];
                    }
                }    
            }
            return summ;
        }
    }
}
