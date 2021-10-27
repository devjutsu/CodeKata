using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class RomanNumerals
    {
        public static string ToRoman(int n)
        => String.Join("",
                        n.ToString()
                        .Select((o, i) => n.ToString().Substring(i).Roman()));

        public static string Roman(this string s)
        {
            if (s.Length == 4)
                return (int.Parse(s) / 1000).Rom('X', 'V', 'M');
            else if (s.Length == 3)
                return (int.Parse(s) / 100).Rom('M', 'D', 'C');
            else if (s.Length == 2)
                return (int.Parse(s) / 10).Rom('C', 'L', 'X');
            else
                return int.Parse(s).Rom('X', 'V', 'I');
        }

        public static string Rom(this int n, char upper, char half, char one)
        {
            var result = "";
            if (n == 9)
                result = $"{one}{upper}";
            else if (n >= 5)
                result = $"{half}{new string(one, n - 5)}";
            else if (n == 4)
                result = $"{one}{half}";
            else if (n > 0)
                result = new string(one, n);

            return result;
        }

        public static Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            ['M'] = 1000,
            ['D'] = 500,
            ['C'] = 100,
            ['L'] = 50,
            ['X'] = 10,
            ['V'] = 5,
            ['I'] = 1
        };
        public static int FromRoman(string s)
        {
            var result = 0;
            for (var i = 0; i < s.Length - 1; i++)
            {
                var current = dict[s[i]];
                var next = dict[s[i + 1]];

                if (current >= next)
                    result += current;
                else result -= current;
            }
            result += dict[s.Last()];

            return result;
        }
    }

    //public class RomanNumerals
    //{
    //    private static readonly string[] R = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    //    private static readonly int[] N = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

    //    public static string ToRoman(int n)
    //    {
    //        Console.WriteLine(n);
    //        var s = new StringBuilder();
    //        for (var i = 0; i < N.Length; i++)
    //        {
    //            while (n >= N[i])
    //            {
    //                s.Append(R[i]);
    //                n -= N[i];
    //            }
    //        }
    //        return s.ToString();
    //    }

    //    public static int FromRoman(string romanNumeral)
    //    {
    //        Console.WriteLine(romanNumeral);
    //        var v = 0;
    //        var s = romanNumeral;
    //        for (var i = 0; i < N.Length; i++)
    //        {
    //            while (s.Substring(0, Math.Min(s.Length, R[i].Length)) == R[i])
    //            {
    //                s = s.Substring(R[i].Length);
    //                v += N[i];
    //            }
    //        }
    //        return v;
    //    }
    //}
}
