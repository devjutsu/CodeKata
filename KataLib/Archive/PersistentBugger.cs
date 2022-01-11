using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class Persist
    {
        public static int Persistence(long n)
            => n.ToString().Length == 1
                ? 0
                : 1 + Persistence(n.ToString().Select(x => int.Parse(x.ToString())).Aggregate((x, y) => x * y));
    }
}
