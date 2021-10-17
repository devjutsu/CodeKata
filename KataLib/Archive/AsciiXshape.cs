using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class AsciiXshape
    {
        public static string X(int n)
            => string.Join("\n", Enumerable.Range(0, n)
                        .Select(o => Enumerable.Range(0, n)
                                      .Select(z => (z == o || o == n - z - 1) ? "■" : "□")
                                ).Select(o => string.Join("", o)));
    }
}
