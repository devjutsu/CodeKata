using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class PokerHandIsFlushTest
    {
        [Test]
        public void BasicTests()
        {
            string[] cards = { "AS", "3S", "9S", "KS", "4S" };
            Assert.AreEqual(true, PokerHandIsFlush.CheckIfFlush(cards));
            string[] cards2 = { "AD", "4S", "7H", "KC", "5S" };
            Assert.AreEqual(false, PokerHandIsFlush.CheckIfFlush(cards2));
            string[] cards3 = { "10D", "4S", "7H", "KC", "5S" };
            Assert.AreEqual(false, PokerHandIsFlush.CheckIfFlush(cards3));
            string[] cards4 = { "10D", "QD", "7D", "KD", "5D" };
            Assert.AreEqual(true, PokerHandIsFlush.CheckIfFlush(cards4));

        }
    }
}
