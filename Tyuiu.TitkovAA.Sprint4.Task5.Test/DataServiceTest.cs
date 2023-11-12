using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint4.Task5.Lib;
namespace Tyuiu.TitkovAA.Sprint4.Task5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();

            int res = 79;

            int[,] a = { {4, 7, 4, -2, 1 },
                        { 6, -7, 3, 6, 5 },
                        { 6, 5, -3, -3, 5 },
                        { 4, -4, 6, 4, 7 },
                        { 2, 1, -2, 3, -4 } };

            Assert.AreEqual(res, dt.Calculate(a));
        }
    }
}
