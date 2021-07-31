using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public partial class Kata
    {
        public static string AlphabetWar(string fight)
        =>
            Message(Score(fight));

        public static string Message(int score)
        =>
            score == 0
                ? "Let's fight again!"
                : score > 0
                    ? "Right side wins!"
                    : "Left side wins!";

        public static int Score(string fight)
        =>
            fight.Sum(c =>
                        ("zdqm").IndexOf(c) + 1
                        - ("sbpw".IndexOf(c) + 1));

    }
}
