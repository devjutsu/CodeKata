using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class AddOne
    {
        public static Func<double, double> Add(double n)
            => x => x + n;
    }
}
