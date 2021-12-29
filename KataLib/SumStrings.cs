using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace KataLib
{
    public class SumStrings
    {
        public static string sumStrings(string a, string b)
        => (BigInteger.Parse(!String.IsNullOrWhiteSpace(a) ? a : "0")
                + BigInteger.Parse(!String.IsNullOrWhiteSpace(b) ? b : "0")).ToString();
    }
}
