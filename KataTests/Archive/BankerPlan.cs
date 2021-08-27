using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    [TestFixture]
    public static class BankerPlanTests
    {

        private static void testing(Boolean actual, Boolean expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing Fortune");
            testing(BankerPlan.Fortune(100000, 1, 2000, 15, 1), true);
            testing(BankerPlan.Fortune(100000, 1, 9185, 12, 1), false);
            testing(BankerPlan.Fortune(100000000, 1, 100000, 50, 1), true);
            testing(BankerPlan.Fortune(100000000, 1.5, 10000000, 50, 1), false);
            testing(BankerPlan.Fortune(100000000, 5, 1000000, 50, 1), true);
        }
    }
}
