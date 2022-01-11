using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class DeleteNthClass
    {
        public static int[] DeleteNth(int[] arr, int x)
            => arr.Select((o, i) => new { N = o, C = arr[0..i].Count(z => z == o) })
                    .Where(o => o.C < x)
                    .Select(o => o.N)
                    .ToArray();
    }
}
