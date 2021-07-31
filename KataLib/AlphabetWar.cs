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
            Message(fight
                        .ToList()
                        .Select(c => CountChar(c))
                        .Sum());

        public static string Message(int score)
        =>
            score == 0
                ? "Let's fight again!"
                : score > 0
                    ? "Right side wins!"
                    : "Left side wins!";


        public static int CountChar(char c)
        =>
            c switch
            {
                'w' => -4,
                'p' => -3,
                'b' => -2,
                's' => -1,
                'm' => 4,
                'q' => 3,
                'd' => 2,
                'z' => 1,
                _ => 0
            };
    }
}
