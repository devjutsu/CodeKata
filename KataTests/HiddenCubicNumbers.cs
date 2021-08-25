using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class HiddenCubicNumbersTest
    {
        [Test]
        public void Test1()
        {
            string s = "0 9026315 -827&()"; // "0 0 Lucky"
            String r = "0 0 Lucky";
            Assert.AreEqual(r, HiddenCubicNumbers.isSumOfCubes(s));
        }

        [Test]
        public void Test2()
        {
            string s = "aqdf&0#1xyz!22[153(777.777";
            String r = "0 1 153 154 Lucky";
            Assert.AreEqual(r, HiddenCubicNumbers.isSumOfCubes(s));
        }

        [Test]
        public void Test3()
        {
            string s = "QK29a45[&erui9026315"; 
            String r = "Unlucky";
            Assert.AreEqual(r, HiddenCubicNumbers.isSumOfCubes(s));
        }

    }
}
