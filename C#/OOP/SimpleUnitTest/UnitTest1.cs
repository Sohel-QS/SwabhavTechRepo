using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;

namespace SimpleUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double num = 2.44;
            var expected = 5.95;

            FindSquare find = new FindSquare();
            double actual = find.Square(num);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var expected = 5.76;
            float num = 2.4f;

            FindSquare find = new FindSquare();
            double actual = find.Square(num);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var expected = 16;
            int num = 4;

            FindSquare find = new FindSquare();
            double actual = find.Square(num);

            Assert.AreEqual(expected, actual);
        }
    }
}
