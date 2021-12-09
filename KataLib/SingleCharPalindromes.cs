using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class SingleCharPalindromes
    {
        public static string solve(string s)
            => s.IsPalindrome() ? "OK"
            : Enumerable.Range(0, s.Length)
                .Select(i => s.Substring(0, i) + s.Substring(i + 1))
                .Any(o => o.IsPalindrome()) ? "remove one"
            : "not possible";

        public static bool IsPalindrome(this string s)
           => s == string.Concat(s.Reverse());
    }
}
