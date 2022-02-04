using System;
using KataLib;
using NUnit.Framework;

namespace Solution
{
    [TestFixture]
    public class PositiveToNegativeBinaryTest
    {
        [TestFixture]
        public class SolutionTest
        {
            int[] Test1 = new int[] { 0, 0, 0, 0 };
            int[] Test2 = new int[] { 0, 0, 1, 0 };
            int[] Test3 = new int[] { 0, 0, 1, 1 };
            int[] Test4 = new int[] { 0, 1, 0, 0 };
            int[] Test5 = new int[] { 0, 1, 0, 0, 1 };


            [Test]
            public void BasicTesting()
            {
                Assert.AreEqual(Test1, PositiveToNegativeBinary.positive2Negative(Test1));
                Assert.AreEqual(new int[] { 1, 1, 1, 0 }, PositiveToNegativeBinary.positive2Negative(Test2));
                Assert.AreEqual(new int[] { 1, 1, 0, 1 }, PositiveToNegativeBinary.positive2Negative(Test3));
                Assert.AreEqual(new int[] { 1, 1, 0, 0 }, PositiveToNegativeBinary.positive2Negative(Test4));
                Assert.AreEqual(new int[] { 1, 0, 1, 1, 1 }, PositiveToNegativeBinary.positive2Negative(Test5));
            }
        }
    }
}