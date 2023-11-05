using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint4.Task0.Lib;
namespace Tyuiu.TitkovAA.Sprint4.Task0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            int[] a = new int[] { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int res = dt.GetSumEvenArrEl(a);
            Assert.AreEqual(res, 26);
        }
    }
}
