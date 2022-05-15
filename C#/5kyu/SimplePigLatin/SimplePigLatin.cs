using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class KataPigIt
{
  public  string PigIt(string str)
  {
    
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