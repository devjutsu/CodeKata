using NUnit.Framework;
using KataLib;

namespace KataTests
{
    public class CatYearsDogYears
    {
        [Test]
        public void One()
        {
            Assert.AreEqual(new int[] { 1, 15, 15 }, Dinglemouse.humanYearsCatYearsDogYears(1));
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual(new int[] { 2, 24, 24 }, Dinglemouse.humanYearsCatYearsDogYears(2));
        }

        [Test]
        public void Ten()
        {
            Assert.AreEqual(new int[] { 10, 56, 64 }, Dinglemouse.humanYearsCatYearsDogYears(10));
        }
    }
}