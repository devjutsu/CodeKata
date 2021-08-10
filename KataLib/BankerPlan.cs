using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class BankerPlan
    {
        public static Boolean Fortune(int f0, double p, int c0, int n, double i)
            => n == 0
                ? true
                : f0 < 0
                    ? false
                    : Fortune((int)Math.Floor(f0 + f0 * 0.01 * p - c0), 
                                p,
                                (int)Math.Floor(c0 + c0 * 0.01 * i), 
                                n - 1, 
                                i);
    }
}
