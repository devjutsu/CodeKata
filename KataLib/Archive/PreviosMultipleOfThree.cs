using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class PreviosMultipleOfThree
    {
        public static int? PreviousMultipleOfThree(int n)
            => n % 3 == 0 ? n
                : n.ToString().Length == 1 ? null
                : PreviousMultipleOfThree(int.Parse(n.ToString().Substring(0, n.ToString().Length - 1)));
    }
}
