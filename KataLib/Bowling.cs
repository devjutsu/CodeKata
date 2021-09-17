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
        {
            var field = new string(' ', 28).ToList();
            for (var i = 1; i <= field.Count; i++)
            {
                if (dc.ContainsKey(i))
                    field[i - 1] = arr.Contains(dc[i]) ? ' ' : 'I';
                else
                    field[i - 1] = ' ';
            }

            return Stringify(field);
        }

        public static string Stringify(List<char> field)
            => string.Join("", field.Take(7)) + "\n"
                        + string.Join("", field.Skip(7).Take(7)) + "\n"
                        + string.Join("", field.Skip(14).Take(7)) + "\n"
                        + string.Join("", field.Skip(21).Take(7));
    }
}
