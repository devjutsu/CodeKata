using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Sum0toN
    {
        public static string ShowSequence(int n)
        {
            if (n == 0)
                return "0=0";
            else if (n < 0)
                return $"{n}<0";

            var seq = Enumerable.Range(0, n + 1).ToList();
            return $"{string.Join("+", seq)} = {seq.Sum()}";
        }
    }
}