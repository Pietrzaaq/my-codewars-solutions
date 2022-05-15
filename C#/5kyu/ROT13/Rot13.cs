using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static string Rot13(string input)
    {
        int MaxLowerCaseCharNumber = 122;
        int MinLowerCaseCharNumber = 97;
        int MaxUpperCaseCharNumber = 90;
        int MinUpperCaseCharNumber = 65;
        int CharNumber = 0;

        var charList = input.Select(x =>                    
        {
        CharNumber = (int) x;

        if(CharNumber >= MinLowerCaseCharNumber && CharNumber <= MaxLowerCaseCharNumber)
        {
            return (char) (CharNumber + 13 > MaxLowerCaseCharNumber ? 
            (MinLowerCaseCharNumber + 13) - (MaxLowerCaseCharNumber - CharNumber) - 1 :
            CharNumber + 13);
        }
        if(CharNumber >= MinUpperCaseCharNumber && CharNumber <= MaxUpperCaseCharNumber)
        {
          return (char) (CharNumber + 13 > MaxUpperCaseCharNumber ? 
          (MinUpperCaseCharNumber + 13) - (MaxUpperCaseCharNumber - CharNumber) - 1 :
          CharNumber + 13);
        }
        return x;
        }).ToList();

        return new string(charList.ToArray());
    }
}