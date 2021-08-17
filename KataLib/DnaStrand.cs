using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KataLib
{
    public static class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            return Regex.Replace(dna, ".", m => $"{"TAGC"["ATCG".IndexOf(m.Value[0])]}");
        }

        // -----------------------------------------------------------

        //static Dictionary<char, char> keyValuePairs = new Dictionary<char, char>()
        //    {
        //        {'A', 'T' },
        //        {'T','A' },
        //        {'C','G' },
        //        {'G','C' }
        //    };

        //public static string MakeComplement(string dna)
        //    => string.Join("", dna.Select(c => keyValuePairs[c]));



        // -----------------------------------------------------------
        //public static string MakeComplement(string dna)
        //    => string.Join("", dna.Select(c => c.SwitchChar()));

        //public static char SwitchChar(this char src) => src switch
        //{
        //    'A' => 'T',
        //    'T' => 'A',
        //    'G' => 'C',
        //    'C' => 'G',
        //    _ => src
        //};
    }
}
