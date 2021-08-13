using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.XPath;

namespace KataLib
{
    public class Evaluator
    {
        public double Evaluate(string expression)
        {
            var xsltExpression =
             string.Format("number({0})",
                 new Regex(@"([\+\-\*])").Replace(expression, " ${1} ")
                                         .Replace("/", " div ")
                                         .Replace("%", " mod "));

            return (double)new XPathDocument
                (new StringReader("<r/>"))
                    .CreateNavigator()
                    .Evaluate(xsltExpression);
        }
    }
}
