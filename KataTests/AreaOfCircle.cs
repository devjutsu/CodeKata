using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    public class AreaOfCircleTest
    {
        [Test]
        public void ShouldFailNegativeNumber()
        {
            Assert.Throws<ArgumentException>(delegate { AreaOfCircle.CalculateAreaOfCircle("-123"); });
            //Assert.Throws(typeof(ArgumentException), Kata.CalculateAreaOfCircle("-123"));
        }

        [Test]
        public void ShouldFailAlphaNumeric()
        {
            Assert.Throws<ArgumentException>(delegate { AreaOfCircle.CalculateAreaOfCircle("number"); });
        }

        [Test]
        public void ShouldPass1()
        {
            Assert.AreEqual(5881.25, AreaOfCircle.CalculateAreaOfCircle("43.2673"));
        }
    }
}
