using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint2.Task1.V22.Lib;

namespace Tyuiu.BelovaEA.Sprint2.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;

            bool[] wait = { true, true, true, false, false, false };

            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(a,b,c,d));
        }
    }
}
