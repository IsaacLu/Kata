using System;
using System.Collections.Generic;

public static class MaxDiffLength 
{
    
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
        if (!a1.IsNullOrEmpty() && !a2.IsNullOrEmpty())
        {
            int MaxDiff = -1;
            
            for (int i = 0; i < a1.Length; i++)
                for (int j = 0; j < a2.Length; j++)
                    if (Math.Abs(a1[i].Length - a2[j].Length) > MaxDiff)
                        MaxDiff = Math.Abs(a1[i].Length - a2[j].Length);
                
            return MaxDiff;
        }
         
        return -1;
    }
        
    public static bool IsNullOrEmpty(this Array array)
    {
        return (array == null || array.Length == 0);
    }
}
