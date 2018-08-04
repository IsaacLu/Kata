using System;
using System.Collections.Generic;

public class RomanConvert
{
  private static readonly Dictionary<int, string> romanDictionary = new Dictionary<int, string>()
  {
    {1000, "M"},
    {900, "CM"},
    {500, "D"},
    {400, "CD"},
    {100, "C"},
    {90, "XC"},
    {50, "L"},
    {40, "XL"},
    {10, "X"},
    {9, "IX"},
    {5, "V"},
    {4, "IV"},
    {1, "I"}
  };
  
  public static string Solution(int n)
  {
    foreach (KeyValuePair<int, string> romanWord in romanDictionary)
    {
      if (n >= romanWord.Key)
        return romanWord.Value + Solution(n - romanWord.Key);
    }
      
    return null;
  }
}
