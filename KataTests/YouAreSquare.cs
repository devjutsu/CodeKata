using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class YouAreSquareTste
    {
        [Test]  
        public static void ShouldWorkForSomeExamples()
        {
            Assert.AreEqual(false, YouAreSquare.IsSquare(177870), "aren't square numbers");
            Assert.AreEqual(false, YouAreSquare.IsSquare(-1), "negative numbers aren't square numbers");
            Assert.AreEqual(false, YouAreSquare.IsSquare(3), "3 isn't a square number");
            Assert.AreEqual(true, YouAreSquare.IsSquare(4), "4 is a square number");
            Assert.AreEqual(true, YouAreSquare.IsSquare(25), "25 is a square number");
            Assert.AreEqual(false, YouAreSquare.IsSquare(26), "26 isn't a square number");
        }
    }
}
