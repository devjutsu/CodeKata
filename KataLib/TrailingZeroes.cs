using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class TrailingZeroes
    {
        public static int TrailingZeros(int n)
        {
            var zeroes = 0;
            for (int i = 5; n / i >= 1; i *= 5)
                zeroes += n / i;
            return zeroes;
        }
    }
}
