using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaberkornEL.Sprint1.Task2.V15.Lib;
namespace Tyuiu.GaberkornEL.Sprint1.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServiceTest ds = new DataServiceTest();
            int x = 2;
            var res = ds.CalculateCubeVolume(x);
            Assert.AreEqual(8, res);
        }
    }
}