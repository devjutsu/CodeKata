using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class Spiralizor
    {
        public static int[,] Spiralize(int size)
        {
            var arr = new int[size, size];
            var start = (0, 0);
            var len = (int)size;
            var prevlen = 0;
            var tail = size % 2 == 1 ? 2 : 1;
            var first = true;

            while (len >= tail)
            {
                if (prevlen == 1)
                    break;

                for (var i = 0; i < len; i++)
                {
                    arr[start.Item2, start.Item1 + i] = 1;
                }
                start = (start.Item1 + len - 1, start.Item2 + 1);

                if (first)
                {
                    first = false;
                    prevlen = len;
                    len--;
                }
                else { prevlen = len; len -= 2; }

                if (len < tail || prevlen == 1 )
                    break;

                for (var i = 0; i < len; i++)
                {
                    arr[start.Item2 + i, start.Item1] = 1;
                }
                start = (start.Item1 - 1, start.Item2 + len - 1);
                prevlen = len;

                if (len < tail || prevlen == 1)
                    break;
                for (var i = 0; i < len; i++)
                {
                    arr[start.Item2, start.Item1 - i] = 1;
                }
                start = (start.Item1 - len + 1, start.Item2 - 1);
                prevlen = len;
                len -= 2;

                if (len < tail || prevlen == 1)
                    break;
                for (var i = 0; i < len; i++)
                {
                    arr[start.Item2 - i, start.Item1] = 1;
                }
                start = (start.Item1 + 1, start.Item2 - len + 1);
                prevlen = len;
            }

            arr.Output(size);
            return arr;
        }

        public static void Output(this int[,] arr, int size)
        {
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    System.Diagnostics.Debug.Write($"{arr[i, j]}");
                }
                System.Diagnostics.Debug.Write($"\n");
            }

            System.Diagnostics.Debug.Write($"\n");
            System.Diagnostics.Debug.Write($"\n");
            System.Diagnostics.Debug.Write($"\n");
        }


        //public static int[,] Spiralize(int n)
        //{
        //    var map = new int[n, n];
        //    int dx = 1, dy = 0;
        //    int x = 0, y = 0;
        //    int s = n - 1;

        //    for (int k = 0; k <= n; k++)
        //    {
        //        // fill line in dig direction
        //        for (int j = 0; j < s; j++)
        //            (map[y, x], x, y) = (1, x + dx, y + dy);

        //        // rotate digger clockwise
        //        (dx, dy) = (-dy, dx);

        //        // find next line length
        //        // it's a simple sequence with difference between even and odds n's
        //        // for n=11: 10 10 10 8 8 6 6 4 4 2 2 1
        //        // for n=10:  9  9  9 7 7 5 5 3 3 1 1 - two 1 on even n's
        //        // for n= 9:  8  8  8 6 6 4 4 2 2 1
        //        // for n= 9:  7  7  7 5 5 3 3 1 1
        //        if (k > 0 && k % 2 == 0) s -= 2;
        //        if (s < 1) s = 1;
        //    }

        //    return map;
        //}

        //-----------------------------------------------------------------------

        //public static int[,] Spiralize(int size)
        //{
        //    var spiral = new int[size, size];
        //    foreach (var p in Walk(-2, 0, 1, 0, size + 1))
        //    {
        //        spiral[p.y, p.x] = 1;
        //    }
        //    return spiral;
        //}

        //private static IEnumerable<(int x, int y)> Walk(int x, int y, int dx, int dy, int l)
        //{
        //    if (l <= 0) yield break;
        //    for (var i = 0; i < l; i++)
        //    {
        //        x += dx;
        //        y += dy;
        //        if (x >= 0) yield return (x, y);
        //        if (l == 1) yield break;
        //    }
        //    foreach (var next in Walk(x, y, -dy, dx, dy == 0 ? l - 2 : l))
        //    {
        //        yield return next;
        //    }
        //}
    }
}
