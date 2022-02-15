using System;
using System.Collections.Generic;
using System.Linq;
namespace KataLib;

public class SumParts
{

    // public static int[] PartsSums(int[] ls)
    //    => ls.Aggregate(new []{ls.Sum()}.AsEnumerable(), (c, n) => c.Prepend(c.First() - n)).Reverse().ToArray();

    public static int[] PartsSums(int[] ls)
    {
        var sum = ls.Sum();
        List<int> result = new List<int>();

        for(var i = 0; i<ls.Length; i++)
        {
            result.Add(sum);
            sum -= ls[i];
        }
        result.Add(0);
        
        return result.ToArray();
    }
}