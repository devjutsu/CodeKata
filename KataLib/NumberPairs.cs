using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class NumberPairs
    {
        public static int[] getLargerNumbers(int[] a, int[] b)
            => a.Select((a, i) => Math.Max(a, b[i])).ToArray();
    }
}
