using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint2.Task3.V11.Lib;

namespace Tyuiu.SorokinAD.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(1.778, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.75, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -8;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.883, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            Assert.AreEqual(-219.95, res);
        }

    }
}
