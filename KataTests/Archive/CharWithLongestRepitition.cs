using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class CharWithLongestRepititionTest
    {
        [Test]
        public void LongestAtTheBeginning()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 4), CharWithLongestRepitition.LongestRepetition("aaaabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 5), CharWithLongestRepitition.LongestRepetition("abbbbb"));
        }

        [Test]
        public void LongestAtTheEnd()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 4), CharWithLongestRepitition.LongestRepetition("bbbaaabaaaa"));
        }

        [Test]
        public void LongestInTheMiddle()
        {
            Assert.AreEqual(new Tuple<char?, int>('u', 3), CharWithLongestRepitition.LongestRepetition("cbdeuuu900"));
        }

        [Test]
        public void MultipleLongest()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 2), CharWithLongestRepitition.LongestRepetition("aabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 1), CharWithLongestRepitition.LongestRepetition("ba"));
        }

        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(new Tuple<char?, int>(null, 0), CharWithLongestRepitition.LongestRepetition(""));
        }
    }
}
