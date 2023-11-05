using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint4.Task1.V26.Lib;

namespace Tyuiu.YangolenkoDS.Sprint4.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();

            int[] array = { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 };
            int res = ds.Calculate(array);
            int wait = 23;

            Assert.AreEqual(wait, res);
        }
    }
}
