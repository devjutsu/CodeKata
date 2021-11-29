using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class PowerOfTwoKata
    {
        public static bool PowerOfTwo(int n)
            => Convert.ToString(n, 2).Count(o => o == '1') == 1;

        // public static bool PowerOfTwo(int n) => new BigInteger(n).IsPowerOfTwo;
    }
}
