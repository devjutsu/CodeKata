using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class RgbToHex
    {
        public static string Rgb(int r, int g, int b)
            => r.Hex() + g.Hex() + b.Hex();

        public static string Hex(this int n)
            => n < 0 ? "00" : n > 255
                        ? 255.ToString("X2")
                        : n.ToString("X2");
    }

    //private static string Hex(this int n)
    //{
    //    var dict = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

    //    n = n < 0 ? 0 : n > 255 ? 255 : n;

    //    return dict[n / 16] + dict[n % 16];
    //}
}
