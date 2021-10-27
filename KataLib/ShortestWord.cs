using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class ShortestWord
    {
        public static int FindShort(string s)
            => s.Split().Min(o => o.Length);
    }
}
