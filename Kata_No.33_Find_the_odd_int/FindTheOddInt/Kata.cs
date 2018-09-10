using System;
using System.Linq;

namespace FindTheOddInt
{
    public class Kata
    {
        public static int find_it(int[] seq)
        {
            //First edition
            //int xor = 0;

            //foreach (int Number in seq)
            //{
            //    xor ^= Number;
            //}

            //return xor;

            //Second edition
            return seq.Aggregate((x, y) => x ^ y);
        }

    }
}
