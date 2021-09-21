using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class AddBigNumbersTest
    {
        [Test]
        public void ASimpleKataTest()
        {
            Assert.AreEqual("110", AddBigNumbers.Add("91", "19"));
            Assert.AreEqual("1111111111", AddBigNumbers.Add("123456789", "987654322"));
            Assert.AreEqual("1000000000", AddBigNumbers.Add("999999999", "1"));
        }
    }
}
