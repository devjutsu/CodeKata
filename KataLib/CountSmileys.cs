using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class CountSmileysClass
    {
        public static int CountSmileys(string[] smileys)
            => smileys.Count(o => o.GotSmiley());

        public static bool GotSmiley(this string text)
            => (text.First() == ':' || text.First() == ';')
                    && (text.Last() == ')' || text.Last() == 'D')
                    && (text.Length == 2 || text[1] == '~' || text[1] == '-');


        //=> smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
    }
}
