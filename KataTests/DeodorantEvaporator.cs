using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class DeodorantEvaporatorTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(29, DeodorantEvaporator.evaporator(10, 10, 5));
        }
    }
}
