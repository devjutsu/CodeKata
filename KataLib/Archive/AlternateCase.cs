using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class AlternateCase
    {
        public static string alternateCase(string s)
            => String.Concat(s.Select(o => char.IsLower(o) ? o.ToString().ToUpper() : o.ToString().ToLower()));
    }
}
