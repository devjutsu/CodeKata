using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class MostProfitFromStockQuotesTests
    {
        private static void Act(int[] quotes, int expected)
        {
            var msg = $"Invalid answer for quotes: [{string.Join(",", quotes)}]";
            var actual = MostProfitFromStockQuotes.GetMostProfitFromStockQuotes(quotes);
            Assert.AreEqual(expected, actual, msg);
        }

        [TestCase("[1, 2, 3, 4, 5, 6]", 15)]
        [TestCase("[6, 5, 4, 3, 2, 1]", 0)]
        [TestCase("[1, 6, 5, 10, 8, 7]", 18)]
        [TestCase("[ 1, 2, 10, 3, 2, 7, 3, 2 ]", 26)]
        public void SampleTests(string input, int expected)
        {
            var quotes = input.Substring(1, input.Length - 2).Split(',').Select(n => int.Parse(n.Trim())).ToArray();
            Act(quotes, expected);
        }
    }
}
