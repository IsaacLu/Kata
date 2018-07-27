public class Kata
{
  public static string GetMiddle(string s)
  {
    if (string.IsNullOrEmpty(s))
      return "";
    else if (s.Length < 3)
      return s; 
    else 
      return GetMiddle(s.Substring(1, (s.Length - 2)));
  }
}
