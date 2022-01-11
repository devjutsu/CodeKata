using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class JosephusSurvivor
    {
        public static int JosSurvivor(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                return (JosSurvivor(n - 1, k) + k - 1) % n + 1;
        }

        //public static int JosSurvivor(int n, int k)
        //{
        //    var test = Enumerable.Range(1, n).ToList();

        //    var i = 1;
        //    var j = 0;
        //    while (test.Count() > 1)
        //    {
        //        i = (j + k) % test.Count;
        //        j = i == 0 ? test.Count - 1 : i - 1;
        //        test.RemoveAt(j);
        //    }

        //    return test.First();
        //}

        //public static int JosSurvivor(int n, int k)
        //{
        //    var test = Enumerable.Range(1, n).ToList();

        //    var i = 1;
        //    var j = 0;
        //    while(test.Count() > 1)
        //    {
        //        i = test.Exec(k, j);
        //        j = i == 0 ? test.Count - 1 : i - 1;
        //        test.RemoveAt(j);
        //    }

        //    return test.First();
        //}

        //public static int Exec(this List<int> seq, int k, int prev)
        //{
        //    var next = (prev + k) % seq.Count;
        //    return next;
        //}

    }
}
