using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class ValidSpacingClass
    {
        public static bool ValidSpacing(string s)
            => s.Trim() == s && !s.Contains("  ");
    }
}
