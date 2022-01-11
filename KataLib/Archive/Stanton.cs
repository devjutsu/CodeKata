using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Stanton
    {
        public static int StantonMeasure(int[] arr)
        => arr.Count(o => o == arr.Count(o => o == 1));
    }
}
