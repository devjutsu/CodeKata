using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KataLib
{
    public static class Decoding
    {
        public static string Decode(string r)
        {
            var nums = Regex.Match(r, @"\d+").Value;
            var numb = int.Parse(nums);

            var hz = r.Replace(nums, "");
            var res = hz.Select(o => o.DecodeChar(numb))
                .ToList();

            return string.Join("", res);
        }

        public static char DecodeChar(this char c, int b)
        {
            var i = (int)c - 97;
            var d = (i * b) % 26;
            var res = d + 97;
            return (char)res;
        }
    }
}
