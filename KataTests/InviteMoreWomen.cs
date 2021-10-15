using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class InviteMoreWomenTest
    {
        [Test]
        public void BasicTests()
        {
            var kata = new InviteMoreWomenForSimpleFun();

            Assert.AreEqual(true, kata.InviteMoreWomen(new int[] { 1, -1, 1 }));

            Assert.AreEqual(true, kata.InviteMoreWomen(new int[] { 1, 1, 1 }));

            Assert.AreEqual(false, kata.InviteMoreWomen(new int[] { -1, -1, -1 }));

            Assert.AreEqual(false, kata.InviteMoreWomen(new int[] { 1, -1 }));

        }
    }
}
