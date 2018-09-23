using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindTheParityOutlier.Test
{
    [TestClass]
    public class FindTheParityOutlierTests
    {
        [TestMethod]
        public void NegativeValue()
        {
            int[] testValue = { 2, 6, 8, -10, 3 };
            Assert.IsTrue(3 == Kata.Find(testValue));
        }
        [TestMethod]
        public void BiggerValues()
        {
            int[] testValue = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Assert.IsTrue(206847684 == Kata.Find(testValue));
        }
        [TestMethod]
        public void BiggestValue()
        {
            int[] testValue = { int.MaxValue, 0, 1 };
            Assert.IsTrue(0 == Kata.Find(testValue));
        }
    }
}
