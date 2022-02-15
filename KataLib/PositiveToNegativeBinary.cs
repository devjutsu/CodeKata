using System;
using System.Linq;
namespace KataLib;

public class PositiveToNegativeBinary
{
    public static int[] positive2Negative(int[] ba)
    {
        return (ba.All(o => o == 0))
            ? ba
            : Convert.ToString(Convert.ToInt32(string.Concat(ba.Select(o => o == 0 ? 1 : 0)), 2) + 1
                                , 2).Select(o => int.Parse(o.ToString())).ToArray();
    }

    // binaryArray.Select((n, i) => binaryArray[(i + 1)..].Sum() > 0 ? 1 - n : n).ToArray();
}