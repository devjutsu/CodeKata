using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    public class SplitInPartsTest
    {
        [TestCase]
        //Fixed values
        public void splitString1()
        {
            string str = "supercalifragilisticexpialidocious";
            Assert.AreEqual("sup erc ali fra gil ist ice xpi ali doc iou s", SplitInPartsKata.SplitInParts(str, 3));
        }

        [TestCase]
        //Fixed values
        public void splitString2()
        {
            string str = "HelloKata";
            Assert.AreEqual("Hel loK ata", SplitInPartsKata.SplitInParts(str, 3));
        }

        [TestCase]
        //Fixed values
        public void splitString3()
        {
            string str = "HelloKata";
            Assert.AreEqual("H e l l o K a t a", SplitInPartsKata.SplitInParts(str, 1));
        }

        [TestCase]
        //Fixed values
        public void splitString4()
        {
            string str = "HelloKata";
            Assert.AreEqual("HelloKata", SplitInPartsKata.SplitInParts(str, 9));
        }
    }
}
