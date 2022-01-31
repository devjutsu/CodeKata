using System;
using System.Linq;
using System.Collections.Generic;
namespace KataLib;

public class MorseCodeDecoder
{
    static Dictionary<string, string> Dic = new Dictionary<string, string>()
                                   {
                                       {"a", ".-"},
                                       {"b", "-..."},
                                       {"c", "-.-."},
                                       {"d", "-.."},
                                       {"e", "."},
                                       {"f", "..-."},
                                       {"g", "--."},
                                       {"h", "...."},
                                       {"i", ".."},
                                       {"j", ".---"},
                                       {"k", "-.-"},
                                       {"l", ".-.."},
                                       {"m", "--"},
                                       {"n", "-."},
                                       {"o", "---"},
                                       {"p", ".--."},
                                       {"q", "--.-"},
                                       {"r", ".-."},
                                       {"s", "..."},
                                       {"t", "-"},
                                       {"u", "..-"},
                                       {"v", "...-"},
                                       {"w", ".--"},
                                       {"x", "-..-"},
                                       {"y", "-.--"},
                                       {"z", "--.."},
                                       {"0", "-----"},
                                       {"1", ".----"},
                                       {"2", "..---"},
                                       {"3", "...--"},
                                       {"4", "....-"},
                                       {"5", "....."},
                                       {"6", "-...."},
                                       {"7", "--..."},
                                       {"8", "---.."},
                                       {"9", "----."},
                                       {"SOS", "...---..."},
                                       {"!", "-.-.--"},
                                       {".", ".-.-.-"},
                                       {" ", ""},
                                   };
    public static string Decode(string morseCode)
	    => string.Concat(morseCode.Trim().Split()
                                    .Select(w => Dic.FirstOrDefault(o => o.Value == w))
                                    .Select(o => o.Key))
                            .ToUpper().Replace("  ", " ");
}