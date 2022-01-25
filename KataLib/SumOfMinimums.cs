using System;
using System.Linq;
namespace KataLib;

public class SumOfMinimumsClass
{
  public static int SumOfMinimums(int[,] numbers)
    => Enumerable.Range(0, numbers.GetLength(0))
                .Select(n => Enumerable.Range(0, numbers.GetLength(1))
                .Select(x => numbers[n,x]).Min()).Sum();
}