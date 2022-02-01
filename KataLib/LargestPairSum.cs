using System;
using System.Linq;
namespace KataLib;

public class LargestPairSumClass
{
  public static int LargestPairSum(int[] numbers)
    => numbers.OrderByDescending(n => n).Take(2).Sum();
}