using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint2.Task7.V11.Lib;

namespace Tyuiu.BelovaEA.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea1()
        {
            DataService ds = new DataService();

            double x = -0.2;
            double y = 0.6;

            Assert.AreEqual(true, ds.CheckDotInShadedArea(x,y));
        }
    }
}
