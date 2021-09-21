using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    public class MaximumDepthOfNestedBracketsTests
    {
        [Test]
        public void RunTest()
        {
            string s = "((AAX(AB)(UP)F(Z))(HH))";
            List<string> expected = new List<string>(new string[] { "AB", "UP", "Z" });
            Assert.AreEqual(expected, MaximumDepthOfNestedBrackets.StringsInMaxDepth(s));

            s = "AA(XX((YY))(U))";
            expected = new List<string>(new string[] { "YY" });
            Assert.AreEqual(expected, MaximumDepthOfNestedBrackets.StringsInMaxDepth(s));

            s = "()(M(P(F((B)A()-))U))(R)";
            var res = MaximumDepthOfNestedBrackets.StringsInMaxDepth(s);
            expected = new List<string>(new string[] { "B","" });
            Assert.AreEqual(expected, res);

            s = "FB(TAIHJK(NZZCGDZXKF(SYMBLACQ)SBJMRFM)PRTRX(JCLYCOXIMOKGGIE)MWIOIJDCLXDSQFHK)WLVYSMNNHIGKR(MOIZLOT(RWMAVXSJQROHJ(GZURPPOQJVMYCE(VCPXSHXQ)LETIEWE(CBC)AAHEEO)NZHIGXBSJATXV)BSBYCMKFFAFZIK(KECNRQ)PIIQZGIDMLNQRQS)VGXXBYD";
            expected = new List<string>(new string[] { "VCPXSHXQ", "CBC" });
            Assert.AreEqual(expected, MaximumDepthOfNestedBrackets.StringsInMaxDepth(s));

            s = "AAA";
            expected = new List<string>(new string[] { "AAA" });
            Assert.AreEqual(expected, MaximumDepthOfNestedBrackets.StringsInMaxDepth(s));

            s = "";
            expected = new List<string>(new string[] { "" });
            Assert.AreEqual(expected, MaximumDepthOfNestedBrackets.StringsInMaxDepth(s));
        }

    }
}
