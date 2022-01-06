using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class SimplyRemoveDuplicates
    {
        public static int[] solve(int[] arr)
        => arr.Reverse().Distinct().Reverse().ToArray();
    }
}
