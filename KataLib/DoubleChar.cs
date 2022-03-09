using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class DoubleCharClass
    {
        public static string DoubleChar(string s)
        => string.Concat(s.Select(o => new string(o, 2)));
    }
}
