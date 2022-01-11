using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
            => n == 0
                ? new double[0]
                : n <= signature.Length
                    ? signature.Take(n).ToArray()
                    : Tribonacci(signature.Concat(new[] { signature.TakeLast(3).Sum() }).ToArray(), n);
    }
}
