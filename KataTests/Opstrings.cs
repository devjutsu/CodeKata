using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class OpstringsTest
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void test1()
        {
            Console.WriteLine("Fixed Tests VertMirror");
            testing(Opstrings.Oper(Opstrings.VertMirror, "hSgdHQ\nHnDMao\nClNNxX\niRvxxH\nbqTVvA\nwvSyRu"),
                "QHdgSh\noaMDnH\nXxNNlC\nHxxvRi\nAvVTqb\nuRySvw");
            testing(Opstrings.Oper(Opstrings.VertMirror, "IzOTWE\nkkbeCM\nWuzZxM\nvDddJw\njiJyHF\nPVHfSx"),
                "EWTOzI\nMCebkk\nMxZzuW\nwJddDv\nFHyJij\nxSfHVP");

            Console.WriteLine("Fixed Tests HorMirror");
            testing(Opstrings.Oper(Opstrings.HorMirror, "lVHt\nJVhv\nCSbg\nyeCt"), "yeCt\nCSbg\nJVhv\nlVHt");
            testing(Opstrings.Oper(Opstrings.HorMirror, "njMK\ndbrZ\nLPKo\ncEYz"), "cEYz\nLPKo\ndbrZ\nnjMK");
        }
    }

    public class Opstrings1Test
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void test1()
        {
            Console.WriteLine("Fixed Tests Rot");
            testing(Opstrings1.Oper(Opstrings1.Rot, "fijuoo\nCqYVct\nDrPmMJ\nerfpBA\nkWjFUG\nCVUfyL"),
                    "LyfUVC\nGUFjWk\nABpfre\nJMmPrD\ntcVYqC\nooujif");
            testing(Opstrings1.Oper(Opstrings1.Rot, "rkKv\ncofM\nzXkh\nflCB"),
                    "BClf\nhkXz\nMfoc\nvKkr");

            Console.WriteLine("Fixed Tests SelfieAndRot");
            testing(Opstrings1.Oper(Opstrings1.SelfieAndRot, "xZBV\njsbS\nJcpN\nfVnP"),
                    "xZBV....\njsbS....\nJcpN....\nfVnP....\n....PnVf\n....NpcJ\n....Sbsj\n....VBZx");
            testing(Opstrings1.Oper(Opstrings1.SelfieAndRot, "uLcq\nJkuL\nYirX\nnwMB"),
                    "uLcq....\nJkuL....\nYirX....\nnwMB....\n....BMwn\n....XriY\n....LukJ\n....qcLu");
        }
    }
}
