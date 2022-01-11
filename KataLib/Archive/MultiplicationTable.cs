using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class MultiplicationTabl
    {
        public static int[,] MultiplicationTable(int size)
        => LinqConvert(Enumerable.Range(1, size)
                .Select(i => new string('x', size))
                .Select((o, i) => o.Select((k, j) => (i + 1) * (j + 1)).ToArray())
                .ToArray());

        static int[,] LinqConvert(int[][] source)
            => new[] { new int[source.Length, source[0].Length] }
                .Select(_ => new { x = _, y = source.Select((a, ia) => a.Select((b, ib) => _[ia, ib] = b).Count()).Count() })
                .Select(_ => _.x)
                .First();
    }
}
