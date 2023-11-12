using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint4.Task5.V5.Lib;

namespace Tyuiu.YangolenkoDS.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
             DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { -5, -2, 0, 2, 3 },
                                         { -3, 7, 7, 4, -1 },
                                         { 5, -6, 4, -5, 4 },
                                         { 7, 4, 7, 3, -3 },
                                         { 4, -6, -5, 5, -6 } };
            int res = ds.Calculate(mtrx);
            int wait = 66;
            Assert.AreEqual(wait, res);
        }
    }
}
