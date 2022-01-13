using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataLib
{
    public class BreadcrumbGenerator
    {
        public static string GenerateBC(string url, string separator)
        {
            // Do the things
            return "";
        }

        string Span(string s)
            => " : <span class=\"active\">HOLIDAYS</span>";

        string Href(string s)
            => " : <a href=\"/pictures/\">PICTURES</a>";

        string Home(string s)
            => "<a href=\"/\">HOME</a>";
    }
}
