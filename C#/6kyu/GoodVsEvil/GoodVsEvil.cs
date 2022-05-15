using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string GoodVsEvil(string good, string evil)
  {
    int[] ptsForRaceGood = {1,2,3,3,4,10};
    int[] ptsForRaceEvil = {1,2,2,2,3,5,10};
    int arraysLength = ptsForRaceGood.Length;
    int[] goodArmy = good.Split(" ").Select(int.Parse).ToArray();
    int[] evilArmy = evil.Split(" ").Select(int.Parse).ToArray();
    int goodPts = 0;
    int evilPts = 0;
    for (int i = 0; i < arraysLength + 1; i++) {
      if(i == 6)
      {
        evilPts += ptsForRaceEvil[i] * evilArmy[i];
      } 
      else 
      {
        goodPts += ptsForRaceGood[i] * goodArmy[i];
        evilPts += ptsForRaceEvil[i] * evilArmy[i];
      }
    }
    if(goodPts == evilPts) return "Battle Result: No victor on this battle field";
    return goodPts > evilPts ? "Battle Result: Good triumphs over Evil" : "Battle Result: Evil eradicates all trace of Good";
  }
}