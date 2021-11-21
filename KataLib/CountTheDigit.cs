using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class CountTheDigit
    {
        public static int NbDig(int n, int d)
            => string.Concat(Enumerable.Range(0, n + 1).Select(i => (i * i).ToString()))
                        .Count(z => z == char.Parse(d.ToString()));
    }
}
