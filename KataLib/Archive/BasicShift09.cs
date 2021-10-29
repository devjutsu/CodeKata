using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class BasicShift09
    {
        public int nextLower(int n)
        {
            var bin = Convert.ToString(Math.Abs(n), 2);

            if (n == 0)
                return -1;
            else if (bin.Count(o => o == '1') > 1)
                if(n > 0)
                    return Convert.ToInt32("1" + new string('0', bin.Length - 1), 2);
                else
                    return Math.Sign(n) * Convert.ToInt32("1" + new string('0', bin.Length), 2);
            else
                return n > 0 ? n >> 1 : n << 1;
        }
    }
}
