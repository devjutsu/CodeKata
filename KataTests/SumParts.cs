using System;
using System.Collections.Generic;
using KataLib;
using NUnit.Framework;

namespace Solution
{
    [TestFixture]
    public class SumPartsTest
    {
        private static void dotest(int[] ls, int[] exp)
        {
            int[] ans = SumParts.PartsSums(ls);
            Assert.AreEqual(exp, ans);
        }
        [Test]
        public static void atest0()
        {
            Console.WriteLine("Basic Tests");
            dotest(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 21, 20, 18, 15, 11, 6, 0 });
            dotest(new int[] { }, new int[] { 0 });
            dotest(new int[] { 0, 1, 3, 6, 10 }, new int[] { 20, 20, 19, 16, 10, 0 });
            dotest(new int[] { 744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358 },
                    new int[] { 10037855, 9293730, 9292795, 9292388, 9291934, 9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0 });

        }
    }
}