using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class TwistedSum
    {
        public static long Solution(long n)
            => (n == 1)
                ? 1
                : n.ToString().Select(o => int.Parse(o.ToString())).Sum() + Solution(n - 1);
    }
}
