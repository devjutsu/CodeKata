using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class SequencesAndSeries
    {
        public static long GetScore(long n)
            => 50 * (n * (n + 1) / 2);

        //public static long GetScore(long n)
        //    => n == 1 ? 50 : n * 50 + GetScore(n-1);
    }
}
