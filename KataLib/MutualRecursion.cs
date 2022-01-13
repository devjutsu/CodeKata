using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class MutualRecursion
    {
        static public int F(int n)
        {
            if (n > 0)
            {
                var newN = n - 1;
                var f = F(newN);
                var m = M(f);
                return n - m;
            }
            else return 1;
        }

        static public int M(int n)
        {
            if (n > 0)
            {
                var newN = n - 1;
                var m = M(newN);
                var f = F(m);
                return n - f;
            }
            else return 0;
        }
    }
}
