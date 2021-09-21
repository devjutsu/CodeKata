using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class CureCancer
    {
        public static int[] MutationLocation(char[][] body)
            => Enumerable.Range(0, body[0].Length)
                .Select(i => body.Position(i))
                .Select((o, i) => new { Row = i, Pos = o })
                .Where(o => o.Pos != null)
                ?.Select(o => new int[] { o.Pos.Value, o.Row })
                ?.SingleOrDefault()
                ?? Array.Empty<int>();

        public static int? Position(this char[][] body, int n)
            => body.Select((x, i) => new { C = x[n], I = i })
                    .GroupBy(x => x.C)
                    .SingleOrDefault(x => x.Count() == 1)
                    ?.Select(o => o.I)
                    ?.SingleOrDefault()
                    ?? null;
    }
}
