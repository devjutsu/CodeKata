using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class BuildASquare
    {
        public static string GenerateShape(int n)
            => string.Join('\n', Enumerable.Range(0, n).Select(x => new string ('+', n)));
    }
}
