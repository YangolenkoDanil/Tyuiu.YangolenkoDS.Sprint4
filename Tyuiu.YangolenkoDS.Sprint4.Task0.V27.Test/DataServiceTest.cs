using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YangolenkoDS.Sprint4.Task0.V27.Lib;

namespace Tyuiu.YangolenkoDS.Sprint4.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

            int wait = 6615;
            int res = ds.GetMultOddArrEl(array);

            Assert.AreEqual(wait, res); 
        }
    }
}
