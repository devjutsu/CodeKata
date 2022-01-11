using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class BitCounting
    {
        public static int CountBits(int n)
        => Convert.ToString(n, 2).Count(x => x == '1');
    }
}
