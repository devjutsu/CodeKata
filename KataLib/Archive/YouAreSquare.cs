using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class YouAreSquare
    {
        public static bool IsSquare(int n)
            => Math.Sqrt(n) % 1 == 0;

        //=> Math.Sqrt(n) == (int) Math.Sqrt(n);

        //=> ((int)Math.Sqrt(n) * (int)Math.Sqrt(n) == n) ? true : false;
    }
}
