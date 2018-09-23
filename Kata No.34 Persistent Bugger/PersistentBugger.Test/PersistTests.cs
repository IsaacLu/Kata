using System;
using PersistentBugger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersistentBugger.Test
{
    [TestClass]
    public class PersistTests
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(4, Persist.Persistence(999));
        }
        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("****** Advanced Tests");
            Assert.AreEqual(3, Persist.Persistence(1111111111111111139));
            Assert.AreEqual(1, Persist.Persistence(1111114111111111111));
            Assert.AreEqual(2, Persist.Persistence(1111111111112511111));
            Assert.AreEqual(4, Persist.Persistence(1111111119991111111));
        }
    }
}
