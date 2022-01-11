using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        => array1.Distinct().Where(x => array2.Any(z => z.Contains(x))).OrderBy(o => o).ToArray();
    }
}
