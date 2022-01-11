using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class ReplaceWithAplhabetPosition
    {
        static string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string AlphabetPosition(string text)
            => string.Join(" ", text.ToUpper()
                        .Where(o => alpha.Contains(o))
                        .Select(o => alpha.ToString().IndexOf(o) + 1));
    }
}
