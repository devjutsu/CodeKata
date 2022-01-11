using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class RoundUpToNextMultupleOf5
    {
        public static int RoundToNext5(int n)
            => n % 5 == 0 ? n : RoundToNext5(n + 1);
    }
}
