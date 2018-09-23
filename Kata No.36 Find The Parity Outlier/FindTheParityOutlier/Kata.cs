using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheParityOutlier
{
    public class Kata
    {
        public static int Find(int[] integers)
        {
            return integers.Count(x => (x % 2).Equals(0)) < integers.Count(x => (x % 2).Equals(1))
                ? integers.FirstOrDefault(x => (x % 2).Equals(0))
                : integers.FirstOrDefault(x => (x % 2).Equals(1));
        }
    }
}
