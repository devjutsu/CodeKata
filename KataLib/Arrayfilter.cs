using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Arrayfilter
    {
        public static int[] GetEvenNumbers(int[] numbers)
            => numbers.Where(x => x % 2 == 0).ToArray();
    }
}
