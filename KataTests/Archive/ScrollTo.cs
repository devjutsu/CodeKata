using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class ScrollToTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(0, ScrollTo.GetSectionId(1, new int[] { 300, 200, 400, 600, 100 }));
            Assert.AreEqual(0, ScrollTo.GetSectionId(299, new int[] { 300, 200, 400, 600, 100 }));
            Assert.AreEqual(1, ScrollTo.GetSectionId(300, new int[] { 300, 200, 400, 600, 100 }));
            Assert.AreEqual(1, ScrollTo.GetSectionId(350, new int[] { 300, 200, 400, 600, 100 }));
            Assert.AreEqual(3, ScrollTo.GetSectionId(1000, new int[] { 300, 200, 400, 600, 100 }));
            Assert.AreEqual(4, ScrollTo.GetSectionId(1599, new int[] { 300, 200, 400, 600, 100 }));
            Assert.AreEqual(-1, ScrollTo.GetSectionId(1600, new int[] { 300, 200, 400, 600, 100 }));
        }
    }
}
