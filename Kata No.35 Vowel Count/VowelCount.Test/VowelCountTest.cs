using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VowelCount;

namespace VowelCount.Test
{
    [TestClass]
    public class VowelCountTest
    {
        [TestMethod]
        public void TestOnlyA() => Assert.AreEqual(2, VowelCount.GetVowelCount("maryland"));
        [TestMethod]
        public void TestOnlyE() => Assert.AreEqual(2, VowelCount.GetVowelCount("teens"));
        [TestMethod]
        public void TestOnlyI() => Assert.AreEqual(2, VowelCount.GetVowelCount("giggling"));
        [TestMethod]
        public void TestOnlyO() => Assert.AreEqual(2, VowelCount.GetVowelCount("blooms"));
        [TestMethod]
        public void TestOnlyU() => Assert.AreEqual(2, VowelCount.GetVowelCount("cupful"));
        [TestMethod]
        public void TestAllVowel() => Assert.AreEqual(5, VowelCount.GetVowelCount("abstemious"));
        [TestMethod]
        public void TestWithCapitalLetters() => Assert.AreEqual(5, VowelCount.GetVowelCount("AbStEmIoUs"));
        [TestMethod]
        public void TestWithDigits() => Assert.AreEqual(3, VowelCount.GetVowelCount("123weird456guy789"));
        [TestMethod]
        public void TestWithSymbols() => Assert.AreEqual(3, VowelCount.GetVowelCount("!@#weird$%^guy&*("));
        [TestMethod]
        public void TestWithSpaces() => Assert.AreEqual(4, VowelCount.GetVowelCount("the weird guy"));
        [TestMethod]
        public void TestWithNull() => Assert.AreEqual(0, VowelCount.GetVowelCount(null));
        [TestMethod]
        public void TestWithEmpty() => Assert.AreEqual(0, VowelCount.GetVowelCount(""));
    }
}
