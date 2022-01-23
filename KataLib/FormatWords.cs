using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace KataLib
{
    public class FormatWordsClass
    {
        public static string FormatWords(string[] words)
        {
            if(words == null) 
                 return "";

            words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            var result = words.Length < 3 
                            ? string.Join(" and ", words)
                            : string.Join(", ", words.Take(words.Length - 1)) + $" and {words.Last()}";

            return result;
        }
    }
}
