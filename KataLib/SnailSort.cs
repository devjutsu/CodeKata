using KataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class SnailSort
    {
        public static int[] Snail(int[][] array)
        {
            var N = array.GetLength(0);
            if (array.GetLength(0) == 1)
                return array[0];

            int c1 = 0, c2 = N - 1;
            var result = new List<int>();
            while (result.Count < N * N)
            {
                for (int i = c1; i <= c2; i++)
                    result.Add(array[c1][i]);

                for (int j = c1 + 1; j <= c2; j++)
                    result.Add(array[j][c2]);

                for (int i = c2 - 1; i >= c1; i--)
                    result.Add(array[c2][i]);

                for (int j = c2 - 1; j >= c1 + 1; j--)
                    result.Add(array[j][c1]);
                c1++;
                c2--;
            }

            return result.ToArray();
        }

        //public static int[] Snail(int[][] array)
        //{
        //    int l = array[0].Length;
        //    int[] sorted = new int[l * l];
        //    Snail(array, -1, 0, 1, 0, l, 0, sorted);
        //    return sorted;
        //}

        //public static void Snail(int[][] array, int x, int y, int dx, int dy, int l, int i, int[] sorted)
        //{
        //    if (l == 0)
        //        return;
        //    for (int j = 0; j < l; j++)
        //    {
        //        x += dx;
        //        y += dy;
        //        sorted[i++] = array[y][x];
        //    }
        //    Snail(array, x, y, -dy, dx, dy == 0 ? l - 1 : l, i, sorted);
        //}
    }
}
