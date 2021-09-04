using System;
using System.Linq;

namespace KataLib
{
    public static class PyramidArray
    {
        public static int[][] Pyramid(int n)
            => Enumerable.Range(0, n)
                                .Select(i => Enumerable.Repeat(1, i + 1).ToArray())
                                .ToArray();
    }
}
