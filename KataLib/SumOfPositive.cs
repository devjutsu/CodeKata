using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
            => arr.Where(x => x > 0).Sum();
    }
}
