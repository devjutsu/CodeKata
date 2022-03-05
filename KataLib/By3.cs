using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace KataLib
{
    public class By3
    {
        public static bool DivisibleByThree(string n)
            => BigInteger.Parse(n) % 3 == 0;
    }
}
