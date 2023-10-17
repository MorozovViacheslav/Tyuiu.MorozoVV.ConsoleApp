using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozovVV.ConsoleApp.Lab3.V0.Lib;
namespace Tyuiu.MorozovVV.ConsoleApp.Lab3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetPoint()
        {
            DataService ds = new DataService();
            int x = -3;
            int y = -3;
            bool res = ds.GetPointShape(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
