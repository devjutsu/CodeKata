using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class ChangingLetters
    {
        public static string Swap(string s)
        => string.Concat(s.Select(x => "aouie".Contains(x) ? x.ToString().ToUpper() : x.ToString() ));
    }
}
