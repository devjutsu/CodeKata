using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class DigitalRootSum
    {
        public int DigitalRoot(long n)
            => n.ToString().Length > 1 
                    ? DigitalRoot(Sum(n.ToString()))
                    : (int)n;

        public int Sum(string s)
            => s.Select(o => int.Parse(o.ToString())).Sum();
    }

    //public long DigitalRoot(long n) => (n - 1) % 9 + 1;
}
