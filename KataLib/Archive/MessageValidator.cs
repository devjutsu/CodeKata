using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KataLib
{
    public class MessageValidator
    {
        public static bool isAValidMessage(string message)
        => Regex.Matches(message, @"(?<d>[\d]+)(?<w>[\D]+)?")
                .All(m => int.Parse(m.Groups["d"].Value) == m.Groups["w"].Value.Length);

        //public static bool isAValidMessage(string message)
        //{
        //    if (string.IsNullOrEmpty(message))
        //        return true;

        //    var hz = Regex.Matches(message, "\\d+|\\D+")
        //            .Select(o => o.Value)
        //            .ToList();

        //    for(var i = 0; i < hz.Count; i++)
        //    {
        //        int.TryParse(hz[i], out int res);
        //        if(res != 0)
        //        {
        //            if (hz.Count < i+2 || hz[i + 1].Count() != res)
        //                return false;
        //            else
        //                i++;
        //        }
        //    }

        //    return true;
        //}
    }
}
