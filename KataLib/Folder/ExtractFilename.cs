using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KataLib
{
    public class FileNameExtractor
    {
        public static string ExtractFileName(string s)
            => Regex.Match(s, @"(?<=_).+(?=\.)").Value;
    }
}
