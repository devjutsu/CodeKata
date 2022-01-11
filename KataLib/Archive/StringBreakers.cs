using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class StringBreakerz
    {
        public static string StringBreakers(int n, string str)
            => string.Join("\n", str.Replace(" ", "")
                            .Select((c, i) => new { c, i })
                            .GroupBy(o => o.i / n)
                            .Select(o => string.Concat(o.Select(z => z.c))));
    }
}
