using System;
using System.Linq;
namespace KataLib;

public static class FindTheParityOutlier
{
    public static int Find(int[] arr)
        => arr.Take(3).Where(o => o % 2 == 0).Count() >= 2 
            ? arr.First(o => o % 2 == 1)
            : arr.First(o => o % 2 == 0);
}