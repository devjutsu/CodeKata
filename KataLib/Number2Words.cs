using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public static class NumberTranslation
    {
        static string[] map = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        static string[] tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        public static string Number2Words(int n) // 0 - 999999
        {
            if (n == 0)
                return "zero";

            string words = "";

            if(n / 1000 > 0)
            {
                words += Number2Words(n / 1000) + " thousand";
                n %= 1000;
            }

            if(n / 100 > 0)
            {
                if (!string.IsNullOrEmpty(words))
                    words += " ";

                words += Number2Words(n / 100) + " hundred";
                n %= 100;
            }

            if(n > 0)
            {
                if (!string.IsNullOrEmpty(words))
                    words += " ";

                if (n < 20)
                    words += map[n];
                else
                {
                    words += tens[n / 10];
                    if (n % 10 > 0)
                        words += "-" + map[n % 10];
                }
            }

            return words;
        }

        
    }
}
