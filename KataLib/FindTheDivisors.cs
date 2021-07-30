using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public partial class Kata
    {
        static Func<int[]?, int[]?> CheckPrimes = (result)
            => result == null || result.Length == 0
                ? null
                : result;

        public static int[]? Divisors(int n)
            => n < 3
                ? null
                : CheckPrimes(GetDivisors(n, n / 2 + 1).ToArray());

        private static int[] GetDivisors(int n, int i)
        =>
            i == 1
                ? new int[0]
                : n % i == 0
                    ? GetDivisors(n, i - 1).Concat(new int[] { i }).ToArray()
                    : GetDivisors(n, i - 1);
    }
}
