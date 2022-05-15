using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Kata
{
  public static string PigIt(string str)
  {
//     StringBuilder sb = new StringBuilder();
    
    string[] words = str.Split(" ").Select(word => {
      if(word.Length == 1) return word;
      word = word.Insert(word.Length, word[0].ToString());
      word = word.Remove(0,1);
      word += "ay";
      System.Console.WriteLine(word);
      return word;
    }).ToList().ToArray();
    
    return string.Join(" ", words);
  }
}