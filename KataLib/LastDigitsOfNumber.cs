using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class LastDigitsOfNumber
    {
        public static int[] LastDigit(long n, int d)
         => n.ToString().Reverse().Take(d).Reverse().Select(o => int.Parse(o.ToString())).ToArray();
    }
}
