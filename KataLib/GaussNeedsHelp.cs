using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class GaussNeedsHelp
    {
        //public static long? RangeSum(long n)
        //{ if (n > 0) return n * (n + 1) / 2; else return null; }

        public static long? RangeSum(long n)
            => n > 0 ? (n * (n + 1) / 2) : 0;
    }
}
