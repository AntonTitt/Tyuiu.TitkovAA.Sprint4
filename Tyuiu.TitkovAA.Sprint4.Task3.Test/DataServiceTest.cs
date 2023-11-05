using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint4.Task3.Lib;
namespace Tyuiu.TitkovAA.Sprint4.Task3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            int[,] a = { {4, 7, 4, 2, 1 },
                        { 6, 7, 3, 6, 5 },
                        { 6, 5, 3, 3, 5 },
                        { 4, 4, 6, 4, 7 },
                        { 2, 1, 2, 3, 4 } };
            int res = dt.Calculate(a);
            Assert.AreEqual(res, 18);

        }
    }
}
