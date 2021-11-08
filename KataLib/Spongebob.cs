using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class Spongebob
    {
        public static string SpongeMeme(string sentence)
            => String.Concat(sentence.Select((c, i) => i % 2 == 0 ? char.ToUpper(c) : char.ToLower(c)));
    }
}
