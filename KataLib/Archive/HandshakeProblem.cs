using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class HandshakeProblem
    {
        public static int GetParticipants(int h)
            => (int)Math.Ceiling((1 + Math.Sqrt(Math.Abs(1 + 4 * h * 2))) / 2);
    }
}
