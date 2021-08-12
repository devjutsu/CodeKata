using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public partial class Factorial
    {
        public static int factorial(int n)
            => n < 2 ? 1 : n * factorial(n - 1);
    }
}
