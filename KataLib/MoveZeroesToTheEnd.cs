using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class MoveZeroesToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
            => arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();

        // arr.OrderBy(x => x==0).ToArray();
    }
}
