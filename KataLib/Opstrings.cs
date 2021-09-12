using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class Opstrings
    {
        public static string[] VertMirror(this string[] src)
            => src.Select(o => string.Join("", o.Reverse())).ToArray();

        public static string[] HorMirror(this string[] src)
            => src.Select((o, i) => src[src.Length - 1 - i]).ToArray();

        public static string Oper(Func<string[], string[]> op, string src)
            => string.Join("\n", op(src.Split("\n")));
    }

    public static class Opstrings1
    {
        public static string[] Rot(this string[] src)
            => src.Select((o, i) => string.Join("", src[src.Length - 1 - i].Reverse()))
                .ToArray();

        public static string[] SelfieAndRot(this string[] src)
            => src.Select(o => o + new string('.', o.Length))
                        .Concat(src.Rot().Select(o => new string('.', o.Length) + o))
                        .ToArray();

        public static string Oper(Func<string[], string[]> op, string src)
            => string.Join("\n", op(src.Split("\n")));
    }
}
