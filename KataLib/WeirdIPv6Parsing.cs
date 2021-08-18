using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace KataLib
{
    public static class WeirdIPv6Parsing
    {
        public static string ParseIPv6(string iPv6)
            => iPv6.Split(iPv6[4])
                    .Select(o => o.CountOctet())
                    .Stringify();

        public static string Stringify(this IEnumerable<int> source)
            => string.Join("", source);

        public static int CountOctet(this string octet)
            => octet.Select(o => Convert.ToInt32(o.ToString(), 16)).Sum();

        //=> octet.Length == 0
        //    ? 0
        //    : CountOctet(octet.Substring(1))
        //        + Convert.ToInt32(octet[0].ToString(), 16);

        // --------------------------------------------------

        //public static string ParseIPv6(string ip) =>
        //        string.Concat(Regex.Matches(ip, @"[0-9A-F]+").Select(m => m.Value.Sum(c => "0123456789ABCDEF".IndexOf(c))));


        //// --------------------------------------------------

        //public static string ParseIPv6(string iPv6)
        //{
        //    return string.Join(string.Empty,
        //        new Regex(@"([0-9a-fA-F]+)")
        //            .Matches(iPv6)
        //            .Select(match => match.Value.Select(Uri.FromHex).Sum())
        //    );
        //}

        //// ---------------------------------------------------

        //public static string ParseIPv6(string iPv6)
        //{
        //    return string.Concat(iPv6.Split(iPv6[4]).Select(x => x.Sum(y => Convert.ToInt32($"{y}", 16))));
        //}
    }
}
