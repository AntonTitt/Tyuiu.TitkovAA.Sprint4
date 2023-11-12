using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint4.Task4.Lib;

namespace Tyuiu.TitkovAA.Sprint4.Task4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            int[,] res ={ {1, 5, 5, 1, 1 },
                        { 7, 1, 1, 7, 5 },
                        { 5, 1, 5, 1, 5 },
                        { 7, 5, 1, 7, 1 },
                        { 1, 7, 7, 1, 1 } },
                        a={ {4, 5, 5, 6, 4 },
                        { 7, 8, 4, 7, 5 },
                        { 5, 6, 5, 8, 5 },
                        { 7, 5, 8, 7, 8 },
                        { 4, 7, 7, 8, 8 } }; ;

            CollectionAssert.AreEqual(res, dt.Calculate(a));
        }
    }
}
