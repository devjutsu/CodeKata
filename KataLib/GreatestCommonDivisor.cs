using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class GreatestCommonDivisor
    {
        public static int Gcd(int a, int b)
            => b == 0 ? a : Gcd(b, a % b);
    }
}
