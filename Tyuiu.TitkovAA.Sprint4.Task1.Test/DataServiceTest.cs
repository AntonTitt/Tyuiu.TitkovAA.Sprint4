using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint4.Task1.Lib;
namespace Tyuiu.TitkovAA.Sprint4.Task1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            int[] a = new int[] { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 };
            int res = dt.Calculate(a);
            Assert.AreEqual(res, 84375);
        }
    }
}
