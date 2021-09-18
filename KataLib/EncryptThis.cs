using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class EncryptThiz
    {
        public static string EncryptThis(string input)
            => string.Join(" ", input.Split().Select(x => x.Encrypt()));

        public static string Encrypt(this string word)
           => word.Length == 0
                   ? ""
                   : word.Length == 1
                       ? ((int)word.First()).ToString()
                        : word.Length == 2
                           ? ((int)word.First()).ToString() + word[1]
                           : ((int)word[0]).ToString()
                           + word.Last()
                           + word[2..^1]
                           + word[1];

        //public static string Encrypt(this string word)
        //    => word.Length == 0
        //            ? ""
        //            : word.Length == 1
        //                ? ((int) word.First()).ToString()
        //                 : word.Length == 2
        //                    ? ((int) word.First()).ToString() + word[1]
        //                    : ((int) word[0]).ToString()
        //                    + word.Last()
        //                    + word.Substring(2, word.Length - 3)
        //                    + word[1];
    }
}
