using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class FindTheStray
    {
        public static int Stray(int[] n)
        => n.GroupBy(o => o).First(o => o.Count() == 1).Key;
    }
}
