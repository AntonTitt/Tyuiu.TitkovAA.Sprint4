using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint4.Task7.Lib;
namespace Tyuiu.TitkovAA.Sprint4.Task7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            int res = 36, a = dt.Calculate(3, 4, "382976421897");
            Assert.AreEqual(res, a);

        }
    }
}
