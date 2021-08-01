using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Arge
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        =>
            p0 >= p
                ? 0
                : 1 + NbYear((int)(p0 + p0 * (percent * 0.01) + aug), percent, aug, p);

    }
}
