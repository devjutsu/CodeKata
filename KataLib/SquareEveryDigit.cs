using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class SquareEveryDigit
    {
        public static int SquareDigits(int n)
            => int.Parse(string.Join("", 
                n.ToString().Select(o => int.Parse(o.ToString())).Select(o => o * o)));
    }
}
