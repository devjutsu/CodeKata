using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Digitalize
    {
        public static int[] digitize(int n)
            => n.ToString().Select(_ => int.Parse(_.ToString())).ToArray();
    }
}
