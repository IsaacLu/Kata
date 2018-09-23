using System;
using System.Collections.Generic;
using System.Linq;

namespace VowelCount
{
    public static class VowelCount
    {
        private static string Vowel = "aeiou";
        public static int GetVowelCount(string str) => string.IsNullOrEmpty(str) ? 0 : str.ToLower().Count(x => Vowel.Contains(x));
    }
}
