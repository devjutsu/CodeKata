using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class BackspacesInString
    {
        public static string CleanString(string s)
        {
            while(s.Contains("#"))
            {
                var i = s.IndexOf("#");
                if (i > 0)
                    s = s.Remove(i - 1, 2);
                else 
                    s = s.Remove(i, 1);
            }
            return s;
        }

        // s.Aggregate("", (a, c) => c == '#' ? a.Any() ? a[..^1] : a : a + c);

        // System.Text.RegularExpressions.Regex.Replace(s, "((?<c>[^#])|(?<-c>#))*(?(c)(?!))#*", "");
    }
}
