using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class ReturnMissing
    {
        public static int GetMissingElement(int[] superImportantArray)
        => 45 - superImportantArray.Sum();
    }
}
