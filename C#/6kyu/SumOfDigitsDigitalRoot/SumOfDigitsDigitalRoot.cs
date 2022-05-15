using System;
using System.Linq;
using System.Collections.Generic;

public class KataDigitalRoot
{
  public int DigitalRoot(long n)
  {
    string charArr = n.ToString();
    while(charArr.Length > 1)
    {
      int sumOfDigits = charArr.Sum(x => int.Parse(x.ToString()));
      Console.WriteLine(sumOfDigits); 
      charArr = sumOfDigits.ToString();
    }
    
    return int.Parse(charArr);
  }
}