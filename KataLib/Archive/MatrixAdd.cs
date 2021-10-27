using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class MatrixAdd
    {
        public static int[][] MatrixAddition(int[][] a, int[][] b)
            => a.Select((x, i) => x.VectorAdd(b[i])).ToArray();

        public static int[] VectorAdd(this int[] a, int[] b)
            => a.Select((x, i) => x + b[i]).ToArray();


        //public static int[][] MatrixAddition(int[][] a, int[][] b)
        //{
        //    return a.Zip(b, (ax, bx) => ax.Zip(bx, (i, j) => i + j).ToArray()).ToArray();
        //}
    }
}
