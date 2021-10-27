using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        => string.Join("", (s1 + s2).Distinct().OrderBy(o => o));
    }
}
