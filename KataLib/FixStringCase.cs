using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class FixStringCase
    {
        public static string Solve(string s)
            => s.Count(c => char.IsLower(c)) < s.Count(c => char.IsUpper(c)) 
                    ? s.ToUpper() 
                    : s.ToLower();
    }
}
