using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class DefineCardSuit
    {
        public static string DefineSuit(string card) => card.Last() switch
        {
            '♣' => "clubs",
            '♦' => "diamonds",
            '♥' => "hearts",
            _ => "spades"
        };
    }
}
