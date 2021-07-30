using System;
using System.Linq;
using NUnit.Framework;
using KataLib;

namespace KataTests
{
    [TestFixture]
    public class FindTheDivisors
    {
        [Test]
        public void SampleTest()
        {

            Assert.AreEqual(null, Kata.Divisors(13));
            Assert.AreEqual(null, Kata.Divisors(2));

            Assert.AreEqual(new int[] { 3, 5 }, Kata.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, Kata.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, Kata.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Kata.Divisors(24));
        }
    }
}
