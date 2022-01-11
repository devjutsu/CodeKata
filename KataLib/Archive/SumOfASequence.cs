using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class SumOfASequence
    {
        public static int SequenceSum(int start, int end, int step)
        => start > end ? 0
            : Enumerable.Range(0, (end - start) / step + 1)
                      .Select(i => start + step * i).Sum();
    }
}
