using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Catalan
    {
        public static BigInteger NthCatalanNumber(int n)
        {
            BigInteger cat = 1;

            for (int i = 1; i < n+1; i++)
            {
                cat *= (4 * i - 2);
                cat /= (i + 1);
            }
            return cat;
        }
    }
}
