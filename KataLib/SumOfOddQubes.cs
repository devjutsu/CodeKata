using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class SumOfOddQubes
    {
        public static int CubeOdd(int[] arr)
            => arr.Where(o => Math.Abs(o) % 2 == 1).Select(o => o * o * o).Sum();
    }
}
