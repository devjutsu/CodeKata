using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class SpongebobTest
    {
        [Test]
        public void Basic_Test()
        {
            var res = Spongebob.SpongeMeme("stop Making spongebob Memes!");
            Assert.AreEqual("StOp mAkInG SpOnGeBoB MeMeS!", res);
        }

        [Test]
        public void Basic_Test1()
        {
            var res = Spongebob.SpongeMeme("colored teens cant Be successful in tech");
            Assert.AreEqual("CoLoReD TeEnS CaNt bE SuCcEsSfUl iN TeCh", res);
        }
    }
}
