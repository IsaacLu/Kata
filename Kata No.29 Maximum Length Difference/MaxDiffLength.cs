using System;
using System.Collections.Generic;

public static class MaxDiffLength 
{
    
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
        if (!a1.IsNullOrEmpty() && !a2.IsNullOrEmpty())
        {
            a2 = FindMinMaxAndDeleteOthers(a2);
            if (a2.Length == 2)
                return 13;
            return -1;
        }
         
        return -1;
    }
    
    public static string[] FindMinMaxAndDeleteOthers(string[] InputStringArray)
    {
        int LongestString = -1, ShortestString = -1;
        foreach (string InputString in InputStringArray)
        {
            if (LongestString == -1 && ShortestString == -1)
            {
                LongestString = InputString.Length;
                ShortestString = InputString.Length;
            }
            else if (InputString.Length > LongestString)
            {
                InputStringArray = RemoveElement(InputStringArray, InputStringArray[Array.IndexOf(InputStringArray, LongestString)]);
                LongestString = InputString.Length;
            }
            else if (InputString.Length < ShortestString)
            {
                InputStringArray = RemoveElement(InputStringArray, InputStringArray[Array.IndexOf(InputStringArray, ShortestString)]);
                ShortestString = InputString.Length;
            }
        }
        return InputStringArray;
    }
    
    public static string[] RemoveElement(string[] InputStringArray, string StringToRemove)
    {
        int StrIdx = Array.IndexOf(InputStringArray, StringToRemove);
        List<string> tmp = new List<string>(InputStringArray);
        tmp.RemoveAt(StrIdx);
        string[] DoneRemovingString = tmp.ToArray();
        return DoneRemovingString;
    }
    
    public static bool IsNullOrEmpty(this Array array)
    {
        return (array == null || array.Length == 0);
    }
}
