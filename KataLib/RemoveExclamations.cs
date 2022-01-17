using KataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class RemoveExclamations
    {
        public static string Remove(string s)
        => string.Concat(s.Where((x, i) => x != '!' || (x == '!') && s.Substring(i).All(c => c == '!')));
    }
}
