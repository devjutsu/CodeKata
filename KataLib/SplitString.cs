using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class SplitString
    {
        public static string[] Solution(string str)
        =>
            (str.Length % 2 == 0
                ? Enumerable.Range(0, str.Length / 2).Select(i => str.Substring(i * 2, 2))
                : Solution(str.Substring(0, str.Length - 1)).Append(str.Substring(str.Length - 1) + "_"))
                    .ToArray();
    }
}
