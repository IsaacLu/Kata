using System;
using FindTheOddInt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindTheOddIntTest
{
    [TestClass]
    public class FindTheOddIntTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, Kata.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}
