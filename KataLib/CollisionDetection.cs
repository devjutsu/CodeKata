using KataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class CollisionDetection
    {
        public static bool Collision(double x1, double y1, double r1, double x2, double y2, double r2)
            => Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)) <= r1+r2;
    }
}
