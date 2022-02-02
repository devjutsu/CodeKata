using System;
using System.Linq;
namespace KataLib;

public class DataReverseClass
{
  public static int[] DataReverse(int[] data)
      => data.Select((c, i) => new { Value = c, I = i })
                       .GroupBy(x => x.I / 8)
                       .Select(g => g.Select(p => p.Value))
                       .Reverse()
                       .SelectMany(o => o).ToArray();
}