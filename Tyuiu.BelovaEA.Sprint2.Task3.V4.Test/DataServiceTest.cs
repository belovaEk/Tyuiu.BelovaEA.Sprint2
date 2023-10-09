using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint2.Task3.V4.Lib;


namespace Tyuiu.BelovaEA.Sprint2.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        
        [TestMethod]
        public void CheckCalculate1()  
        {
            double x = 2;
            Assert.AreEqual(11, ds.Calculate(x));
        }
        [TestMethod]
        public void CheckCalculate2()
        {
            double x = 0;
            Assert.AreEqual(0.083, ds.Calculate(x));
        }
        [TestMethod]
        public void CheckCalculate3()
        {
            double x = -1;
            Assert.AreEqual(-0.5, ds.Calculate(x));
        }
        [TestMethod]
        public void CheckCalculate4()
        {
            double x = -10;
            Assert.AreEqual(-109.9, ds.Calculate(x));
        }
    }
}
