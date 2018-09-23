using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumOfDigitsOrDigitalRoot.Test
{
    [TestClass]
    public class NumberTest
    {
        private Number num = new Number();
        [TestMethod]
        public void NormalTest() => Assert.AreEqual(7, num.DigitalRoot(16));
        [TestMethod]
        public void BiggerNumTest() => Assert.AreEqual(9, num.DigitalRoot(123456789));
        [TestMethod]
        public void ZeroTest() => Assert.AreEqual(0, num.DigitalRoot(0));
    }
}
