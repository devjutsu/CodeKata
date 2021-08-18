using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class IntSqRoot
    {
        public static long IntRac(this long n, long x)
            => x == (int)Math.Sqrt(n)
                    ? 1
                    : 1 + n.IntRac((x + n / x) / 2);
    }
}
