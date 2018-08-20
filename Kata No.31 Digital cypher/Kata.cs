using System.Linq;
using System;

public  class Kata
{
    public static int[] Encode(string PlainText, int Key)
    {
        char[] KeyChar = Key.ToString().ToCharArray();
        int[] EncodeResult = new int[PlainText.Length];
        
        for (int Letter = 0, DigitNumber = 0; Letter < PlainText.Length; Letter++, DigitNumber++)
        {
            if(DigitNumber >= KeyChar.Length)
                DigitNumber = 0;
            EncodeResult[Letter] = ((int) Char.ToLower(PlainText[Letter]) - 96) + int.Parse(KeyChar[DigitNumber].ToString());
        }
               
        return EncodeResult;
    }
}
