using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Dinglemouse
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        => new int[]
        {
            humanYears,
            humanYears > 2
                ? 24 + (humanYears - 2) * 4
                : 15 + (humanYears - 1) * 9,
            humanYears > 2
                ? 24 + (humanYears - 2) * 5
                : 15 + (humanYears - 1) * 9
        };
    }
}
