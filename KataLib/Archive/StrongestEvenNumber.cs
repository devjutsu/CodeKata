using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class StrongestEvenNumber
    {
        public static int strongestEven(int n, int m)
        {
            while (n <= (m & m - 1))
                m = m & m - 1;

            return m;
        }

        //public static int strongestEven(int n, int m)
        //{
        //    //Console.WriteLine($"{n} : {m}");
        //    int s = 0;
        //    int bitCount = -1;
        //    for (int i = n; i <= m; ++i)
        //    {
        //        int currentBitCount = BitOperations.TrailingZeroCount(i);
        //        var bin = System.Convert.ToString(i, 2);
        //        if (currentBitCount > bitCount)
        //        {
        //            bitCount = currentBitCount;
        //            s = i;
        //        }
        //        if (i % (32 * 32 * 32) == 0)
        //        {
        //            i += 32 * 32 * 32 - 1;
        //        }
        //        else if (i % (32 * 32) == 0)
        //        {
        //            i += 32 * 32 - 1;
        //        }
        //        else if (i % 32 == 0)
        //        {
        //            i += 31;
        //        }
        //    }
        //    return s;
        //}
    }
}
