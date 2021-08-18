using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class DigPow
    {
        public static long digPow(int n, int p)
            => n.ToString()
                .GetDigitSum(n, p, 0)
                .GetResult(n);

        public static int GetDigitSum(this string str, int n, int p, int pow)
            => str.Length == 0
                ? 0
                : (int)Math.Pow(int.Parse(str.First().ToString()), p + pow)
                        + GetDigitSum(str.Substring(1), n, p, pow + 1);

        public static int GetResult(this int sum, int n)
            => sum / n * n == sum
                ? sum / n
                : -1;


        // ----------------------------------------------------
        public static long digPow2(int n, int p)
        {
            var sum = Convert.ToInt64(n.ToString().Select(s => Math.Pow(int.Parse(s.ToString()), p++)).Sum());
            return sum % n == 0 ? sum / n : -1;
        }
    }
}
