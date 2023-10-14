using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint2.Task6.V7.Lib;

namespace Tyuiu.BelovaEA.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindMonthName()
        {
            DataService ds = new DataService();
            int n = 2;
            Assert.AreEqual("Март", ds.FindMonthName(1990,n));
        }

        [TestMethod]
        public void CheckFindMonthName1()
        {
            DataService ds = new DataService();
            int n = -1;
            Assert.AreEqual("Ошибка", ds.FindMonthName(1990, n));
        }


    }
}
