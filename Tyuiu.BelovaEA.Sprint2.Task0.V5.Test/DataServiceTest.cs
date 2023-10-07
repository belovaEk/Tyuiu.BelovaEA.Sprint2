using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint2.Task0.V5.Lib;

namespace Tyuiu.BelovaEA.Sprint2.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetCompareOperations()
        {
            DataService ds = new DataService();

            int x = 105;
            int y = 223;
            bool[] res = { false, true, true, true, false, true };
            CollectionAssert.AreEqual(res, ds.GetCompareOperations(x, y));
        }
    }
}
