using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint2.Task6.V7.Lib;

namespace Tyuiu.SorokinAD.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Январь 1990 года", ds.FindMonthName(1990, 0));
            Assert.AreEqual("Февраль 1990 года", ds.FindMonthName(1990, 1));
            Assert.AreEqual("Март 1990 года", ds.FindMonthName(1990, 2));
            Assert.AreEqual("Апрель 1990 года", ds.FindMonthName(1990, 3));
            Assert.AreEqual("Май 1990 года", ds.FindMonthName(1990, 4));
            Assert.AreEqual("Июнь 1990 года", ds.FindMonthName(1990, 5));
            Assert.AreEqual("Июль 1990 года", ds.FindMonthName(1990, 6));
            Assert.AreEqual("Август 1990 года", ds.FindMonthName(1990, 7));
            Assert.AreEqual("Сентябрь 1990 года", ds.FindMonthName(1990, 8));
            Assert.AreEqual("Октябрь 1990 года", ds.FindMonthName(1990, 9));
            Assert.AreEqual("Ноябрь 1990 года", ds.FindMonthName(1990, 10));
            Assert.AreEqual("Декабрь 1990 года", ds.FindMonthName(1990, 11));
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthName(1990,-1);
            });
        }
    }
}
