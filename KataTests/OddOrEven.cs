using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    [TestFixture]
    public class OddOrEven
    {
        [Test, Description("Edge tests")]
        public void EdgeTests()
        {
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 1 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { }));
        }

        [Test, Description("Even tests")]
        public void EvenTests()
        {
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, 1, 5 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, 1, 3 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 1023, 1, 2 }));
        }

        [Test, Description("Negative Even tests")]
        public void NegativeEvenTests()
        {
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, -1, -5 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { 0, -1, -3 }));
            Assert.AreEqual("even", Kata.OddOrEven(new int[] { -1023, 1, -2 }));
        }

        [Test, Description("Odd tests")]
        public void OddTests()
        {
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, 1, 2 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, 1, 4 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 1023, 1, 3 }));
        }

        [Test, Description("Negative Odd tests")]
        public void NegativeOddTests()
        {
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, -1, 2 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { 0, 1, -4 }));
            Assert.AreEqual("odd", Kata.OddOrEven(new int[] { -1023, -1, 3 }));
        }
    }
}
