using System;
using NUnit.Framework;

[TestFixture]
public static class MaxDiffLengthTests {

[Test]
    public static void test1() 
    {
        string[] s1 = new string[]{"hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"};
        string[] s2 = new string[]{"cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"};
        string[] s3 = new string[]{};
        string[] s4 = new string[]{"a", "aa", "aaa"};
        Assert.AreEqual(13, MaxDiffLength.Mxdiflg(s1, s2));
        Assert.AreEqual(-1, MaxDiffLength.Mxdiflg(s1, s3));
        Assert.AreEqual(10, MaxDiffLength.Mxdiflg(s1, s4));
        Assert.AreEqual(-1, MaxDiffLength.Mxdiflg(s2, s3));
        Assert.AreEqual(15, MaxDiffLength.Mxdiflg(s2, s4));
        Assert.AreEqual(-1, MaxDiffLength.Mxdiflg(s3, s4));
    }
}
