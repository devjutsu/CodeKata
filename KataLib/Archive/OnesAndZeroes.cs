using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class OnesAndZeroes
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
            => Convert.ToInt32(string.Concat(BinaryArray), 2);
    }
}
