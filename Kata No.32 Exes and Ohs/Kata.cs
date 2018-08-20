using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
      return (input.ToLower().Count(Letter => Letter == 'x') == input.ToLower().Count(Letter => Letter == 'o'));
  }
}
