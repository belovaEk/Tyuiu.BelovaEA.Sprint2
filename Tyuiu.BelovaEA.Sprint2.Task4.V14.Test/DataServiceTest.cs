using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint2.Task4.V14.Lib;

namespace Tyuiu.BelovaEA.Sprint2.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void CheckCalculate1()
        {
            double x = 2;
            double y = 1;
            Assert.AreEqual(2.25,ds.Calculate(x,y));
        }

        [TestMethod]

        public void CheckCalculate2()
        {
            double x = 10;
            double y = 1;
            Assert.AreEqual(0.091, ds.Calculate(x, y));
        }

    }
}
