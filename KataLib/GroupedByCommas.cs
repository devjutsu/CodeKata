using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class GroupedByCommas
    {
        public static string GroupByCommas(int n)
            => string.Join(",", n.ToString()
                        .Reverse()
                        .Select((c, i) => new { c, i })
                        .GroupBy(x => x.i / 3)
                        .Select(o => string.Concat(o.Select(z => z.c).Reverse()))
                        .Reverse()
                        .ToList());

        //public static string GroupByCommas(int n) => $"{n:n0}";
    }
}
