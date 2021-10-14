using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class StrongNumberCheck
    {
        public static string StrongNumber(int n)
        => n.ToString().Sum(o => int.Parse(o.ToString()).Fact()) == n
                ? "STRONG!!!!"
                : "Not Strong !!";

        public static int Fact(this int n)
        => n == 0
                   ? 1
                   : Enumerable.Range(1, n).Aggregate((i, j) => i * j);
    }
}
