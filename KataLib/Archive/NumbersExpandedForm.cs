using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class NumbersExpandedForm
    {
        public static string ExpandedForm(long num)
            => num.ToString()
                        .Reverse()
                        .Select((o, i) => int.Parse(o.ToString()) * Math.Pow(10, i))
                        .Where(o => o > 0)
                        .Reverse()
                        .Select(o => o.ToString()).Aggregate((a, b) => $"{a} + {b}");
    }
}
