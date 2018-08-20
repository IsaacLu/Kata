namespace Learning {
  using NUnit.Framework;
  using System;
  [TestFixture]
  public class CypherTest
  {
    [Test]
    public void BasicTest()
    {
        Assert.AreEqual(new int[] {9, 24, 26}, Kata.Encode("HOW", 1939));
        Assert.AreEqual(new int[] {20, 12, 18, 30, 21}, Kata.Encode("scout", 1939));
        Assert.AreEqual(new int[] {14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8}, Kata.Encode("masterpiece", 1939));
       
    }
   }
 }
