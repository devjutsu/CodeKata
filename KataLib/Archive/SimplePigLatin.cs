using System.Text.RegularExpressions;

namespace KataLib
{
    public partial class Kata
    {
        public static string PigIt(string str)
        =>
            Regex.Replace(str, @"((\S)(\S+))", "$3$2ay");
    }
}
