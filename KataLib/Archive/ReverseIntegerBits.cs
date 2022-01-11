using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class ReverseIntegerBits
    {
        public static long ReverseBits(long n)
            => Convert.ToInt64(string.Concat(Convert.ToString(n, 2).Reverse()), 2);
    }
}
