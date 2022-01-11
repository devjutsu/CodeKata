using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class DryPotatoes
    {
        public static int Potatoes(int p0, int w0, int p1)
            => w0 * (100 - p0) / (100 - p1);
    }
}
