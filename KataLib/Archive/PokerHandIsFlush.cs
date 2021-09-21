using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class PokerHandIsFlush
    {
        public static bool CheckIfFlush(string[] cards)
            => cards.GroupBy(o => o.Last()).Any(o => o.Count() == 5);
    }
}
