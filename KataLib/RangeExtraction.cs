using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class RangeExtraction
    {
        public int Value, Count;
        public int NextValue => Value + Count;

        public RangeExtraction(int value)
        {
            Value = value;
            Count = 1;
        }

        public override string ToString()
            => Count == 1 
                ? $"{Value}" 
                : Count == 2 
                    ? $"{Value},{Value + 1}" 
                    : $"{Value}-{NextValue - 1}";

        public static string Extract(int[] args)
        {
            var list = new List<RangeExtraction>();

            foreach (var n in args)
                if (list.LastOrDefault()?.NextValue == n) list.Last().Count++;
                else list.Add(new RangeExtraction(n));

            return string.Join(",", list);
        }
    }
}
