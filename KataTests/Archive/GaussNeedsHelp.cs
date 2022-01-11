using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class GaussNeedsHelpTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(100l).Returns(5050l);
                yield return new TestCaseData(300l).Returns(45150l);
                yield return new TestCaseData(50000l).Returns(1250025000l);
            }
        }

        [Test, TestCaseSource("testCases")]
        public long? Test(long n) => GaussNeedsHelp.RangeSum(n);
    }
}
