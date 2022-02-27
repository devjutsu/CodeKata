using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class FindTheVowelsTest
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(new int[] { }, FindTheVowels.VowelIndices("mmm"));
            Assert.AreEqual(new int[] { 1, 5 }, FindTheVowels.VowelIndices("apple"));
            Assert.AreEqual(new int[] { 2, 4 }, FindTheVowels.VowelIndices("super"));
            Assert.AreEqual(new int[] { 1, 3, 6 }, FindTheVowels.VowelIndices("orange"));
            Assert.AreEqual(new int[] { 2, 4, 7, 9, 12, 14, 16, 19, 21, 24, 25, 27, 29, 31, 32, 33 }, FindTheVowels.VowelIndices("supercalifragilisticexpialidocious"));
        }
    }
}
