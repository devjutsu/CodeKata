using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class BuildTower
    {
        public static string[] TowerBuilder(int nFloors)
            => Enumerable.Range(1, nFloors).Select(i => i.Floor(nFloors)).ToArray();

        public static string Floor(this int n, int count)
            => $"{new string(' ', count - n)}" +
                    $"{new string('*', n * 2 - 1)}" +
                    $"{new string(' ', count - n)}";
    }
}