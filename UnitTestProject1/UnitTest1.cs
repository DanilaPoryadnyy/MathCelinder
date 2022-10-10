using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp12;

namespace UnitTestProject1
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            double a = 3;
            double b = 5;
            double expected = 3.14 * (a * a) * b;

            Geometry g = new Geometry();
            double actual = g.aaa(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}