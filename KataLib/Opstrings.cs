using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class Opstrings
    {
        public static string[] VertMirror(string[] src)
            => src.Select(o => string.Join("", o.Reverse())).ToArray();

        public static string[] HorMirror(string[] src)
            => src.Select((o, i) => src[src.Length - 1 - i]).ToArray();

        public static string Oper(Func<string[], string[]> op, string src)
            => string.Join("\n", op(src.Split("\n")));
    }
}
