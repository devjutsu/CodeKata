using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class BinaryAdditionTest
    {
        [TestFixture]
        public class AddBinaryTest
        {
            [Test]
            public void TestExample()
            {
                Assert.AreEqual("11", BinaryAddition.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
            }
        }
    }
}
