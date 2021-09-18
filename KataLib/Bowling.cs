using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Bowling
    {
        Dictionary<int, int> dc = new Dictionary<int, int>
        {
            [1] = 7,
            [3] = 8,
            [5] = 9,
            [7] = 10,
            [9] = 4,
            [11] = 5,
            [13] = 6,
            [17] = 2,
            [19] = 3,
            [25] = 1
        };

        public string BowlingPins(int[] arr)
            => Stringify(new string(' ', 28).Select((o, i) => Sym(o, i + 1, arr)).ToList());

        public char Sym(char c, int i, int[] arr)
            => dc.ContainsKey(i)
                    ? arr.Contains(dc[i]) ? ' ' : 'I'
                    : ' ';

        public static string Stringify(List<char> field)
            => string.Join("", field.Take(7)) + "\n"
                        + string.Join("", field.Skip(7).Take(7)) + "\n"
                        + string.Join("", field.Skip(14).Take(7)) + "\n"
                        + string.Join("", field.Skip(21).Take(7));
    }

    //public class Bowling
    //{
    //    public string BowlingPins(int[] arr)
    //      => string.Format("{6} {7} {8} {9}\n {3} {4} {5} \n  {1} {2}  \n   {0}   ", Enumerable.Range(1, 10).Select(x => arr.Contains(x) ? " " : "I").ToArray());
    //}
}
