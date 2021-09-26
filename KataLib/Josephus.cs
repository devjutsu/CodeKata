using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class Josephus
    {
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            var result = new List<object>();

            var i = 1;
            var j = 0;
            while(items.Count() > 0)
            {
                i = (j + k) % items.Count;
                j = i == 0 ? items.Count - 1 : i - 1;
                result.Add(items[j]);
                items.RemoveAt(j);
            }

            return result;
        }
    }
}
