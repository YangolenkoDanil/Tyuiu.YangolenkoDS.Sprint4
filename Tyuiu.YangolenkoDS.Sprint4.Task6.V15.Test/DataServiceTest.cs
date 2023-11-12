using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint4.Task6.V15.Lib;

namespace Tyuiu.YangolenkoDS.Sprint4.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            var str = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            int res = ds.Calculate(str);
            int wait = 3; 
            Assert.AreEqual(wait, res);
        }
    }
}
