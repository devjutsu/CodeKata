using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Multiplies3or5
    {
        public static int Solution(int value)
            => RecursiveFind(value - 1);

        public static int RecursiveFind(int n)
        => n < 3
            ? 0
            : n % 3 == 0 || n % 5 == 0
                ? n + RecursiveFind(n - 1)
                : RecursiveFind(n - 1);

        // ------------------------------------------
        public static int Solution2(int n)
            => Enumerable.Range(0, n)
                            .Where(e => e % 3 == 0 || e % 5 == 0)
                            .Sum();
    }
}
