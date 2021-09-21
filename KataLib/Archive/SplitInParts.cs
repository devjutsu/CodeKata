using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KataLib
{
    public static class SplitInPartsKata
    {
        public static string SplitInParts(string s, int partLength)
            => s.Length <= partLength
            ? s
            : s.Substring(0, partLength) 
                    + " " 
                    + SplitInParts(s.Substring(partLength), partLength);


        //public static string SplitInParts(string s, int l)
        //{
        //    return string.Join(" ", Regex.Matches(s, $".{{1,{l}}}"));
        //}

        //public static string SplitInParts(string s, int l)
        //{
        //    return Regex.Replace(s, $"(.{{{l}}})", "$1 ").Trim();
        //}
    }
}
