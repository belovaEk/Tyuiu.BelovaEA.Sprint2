using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint2.Task2.V17.Lib;

namespace Tyuiu.BelovaEA.Sprint2.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 14;
            int y = 7;
            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
        }
    }
}
