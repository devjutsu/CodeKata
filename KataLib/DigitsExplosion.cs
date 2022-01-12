using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class DigitsExplosion
    {
        public static string Explode(string s)
            => string.Concat(s.Select(o => new string(o, int.Parse(o.ToString()))));
    }
}
