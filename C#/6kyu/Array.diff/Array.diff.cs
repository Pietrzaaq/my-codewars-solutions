using System;
using System.Collections.Generic;
using System.Linq;

public class KataArrayDiff
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
     return  a.Where(x => !b.Any(y => y == x)).ToArray();
  }
}