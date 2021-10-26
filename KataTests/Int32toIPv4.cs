using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class Int32toIPv4Test
    {
        [Test, Description("Sample Tests")]
        public void Test()
        {
            Assert.AreEqual("128.114.17.104", Int32toIPv4.UInt32ToIP(2154959208));
            Assert.AreEqual("0.0.0.0", Int32toIPv4.UInt32ToIP(0));
            Assert.AreEqual("128.32.10.1", Int32toIPv4.UInt32ToIP(2149583361));
            Assert.AreEqual("0.0.0.32", Int32toIPv4.UInt32ToIP(32));
        }
    }
}
