using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class PatternWave
    {
        public static string Draw(int[] waves)
            => string.Join("\n", Enumerable.Range(1, waves.Max())
                .Select(o => string.Concat(waves.Select(x => (waves.Max() - o) < x ? '■' : '□'))));
    }
}
