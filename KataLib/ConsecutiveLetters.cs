using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class ConsecutiveLetters
    {
        public static bool solve(string s)
            => s.GroupBy(o => o).All(o => o.Count() == 1)
                        && s.Max() - s.Min() + 1 == s.Length;
    }
}
