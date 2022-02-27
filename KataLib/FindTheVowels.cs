using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class FindTheVowels
    {
        public static int[] VowelIndices(string word)
            => word.ToLower().Select((o, i) => new { o, i })
                                    .Where(x => new char[] { 'a', 'e', 'i', 'o', 'u', 'y' }
                                    .Contains(x.o))
                                    .Select(x => x.i + 1)
                                    .ToArray();
    }
}
